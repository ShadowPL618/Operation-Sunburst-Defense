using System;
using System.Drawing;
using System.IO.Ports;
using System.Windows.Forms;

namespace Astroidinator_SDE2025_Jkra
{
    /// <summary>
    /// Handles all communication with the Arduino UNO R4 WiFi.
    /// - Opens / closes serial port
    /// - Sends optional CR/LF
    /// - Reads incoming joystick commands (UP/DOWN/LEFT/RIGHT/FIRE/STOP)
    /// - Sends data to Serial Monitor and to Game Logic
    /// </summary>
    internal class arduinoConnect
    {
        private SerialPort serialPort;

        // Buffer for assembling lines from ReadExisting()
        private string inputBuffer = "";

        // UI elements (from Form1)
        private readonly RichTextBox loggingBox;
        private readonly ComboBox portComboBox;
        private readonly ComboBox baudrateComboBox;

        // TX options (set by Form1 checkboxes)
        public bool RemoveLastChar { get; set; }
        public bool CarriageReturn { get; set; }
        public bool NewLine { get; set; }

        // Events exposed to Form1
        public event Action<string> DataReceived;          // Game input event
        public event Action<string> SerialMonitorReceived; // Serial monitor event

        //---------------------------------------------------------------
        //  Constructor
        //---------------------------------------------------------------
        public arduinoConnect(RichTextBox logging, ComboBox portBox, ComboBox baudrateBox)
        {
            loggingBox = logging;
            portComboBox = portBox;
            baudrateComboBox = baudrateBox;

            serialPort = new SerialPort();

            // IMPORTANT for Arduino UNO R4 WiFi:
            // - DTR OFF prevents board from auto-rebooting on connect
            // - RTS OFF also prevents unwanted reset spikes
            serialPort.DtrEnable = false;
            serialPort.RtsEnable = false;

            serialPort.DataReceived += DataReceivedHandler;
        }

        //---------------------------------------------------------------
        //  Scan available COM ports
        //---------------------------------------------------------------
        public void ScanPorts()
        {
            try
            {
                portComboBox.Items.Clear();
                string[] ports = SerialPort.GetPortNames();

                if (ports.Length == 0)
                {
                    Log("No COM ports found.", Color.Orange, "WARNING");
                    return;
                }

                foreach (string port in ports)
                {
                    portComboBox.Items.Add(port);
                    Log($"Found port: {port}", Color.LawnGreen, "INFO");
                }

                portComboBox.SelectedIndex = 0;
                Log("Scan complete.", Color.LawnGreen, "INFO");

            }
            catch (Exception ex)
            {
                Log($"Scan failed: {ex.Message}", Color.Red, "ERROR");
            }
        }

        //---------------------------------------------------------------
        //  Open / Close port
        //---------------------------------------------------------------
        public bool OpenPort()
        {
            if (portComboBox.SelectedItem == null)
            {
                Log("No COM port selected.", Color.Orange, "WARNING");
                return false;
            }

            if (baudrateComboBox.SelectedItem == null)
            {
                Log("No baudrate selected.", Color.Orange, "WARNING");
                return false;
            }

            try
            {
                if (serialPort.IsOpen)
                {
                    serialPort.Close();
                    Log("Port closed.", Color.Orange, "INFO");
                    return false;
                }

                serialPort.PortName = portComboBox.SelectedItem.ToString();
                serialPort.BaudRate = int.Parse(baudrateComboBox.SelectedItem.ToString());

                // UNO R4 requires delay after opening to stabilize USB CDC
                serialPort.Open();
                System.Threading.Thread.Sleep(1000);

                Log($"Port {serialPort.PortName} opened at {serialPort.BaudRate} baud.", Color.LawnGreen, "INFO");
                return true;
            }
            catch (Exception ex)
            {
                Log($"Failed to open port: {ex.Message}", Color.Red, "ERROR");
                return false;
            }
        }

        //---------------------------------------------------------------
        public bool IsConnected() => serialPort.IsOpen;

        //---------------------------------------------------------------
        //  Send data to Arduino
        //---------------------------------------------------------------
        public void Send(string data)
        {
            if (!serialPort.IsOpen)
            {
                Log("Cannot send: port is closed.", Color.Red, "ERROR");
                return;


            }

            try
            {
                string msg = data;

                if (RemoveLastChar && msg.Length > 0)
                    msg = msg.Substring(0, msg.Length - 1);

                if (CarriageReturn)
                    msg += "\r";

                if (NewLine)
                    msg += "\n";

                serialPort.Write(msg);
            }
            catch (Exception ex)
            {
                Log($"Send failed: {ex.Message}", Color.Red, "ERROR");
            }
        }

        //---------------------------------------------------------------
        //  Receive data from Arduino
        //---------------------------------------------------------------
        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                // Read all available characters
                string incoming = serialPort.ReadExisting();
                inputBuffer += incoming;

                // Split at newline(s)
                string[] lines = inputBuffer.Split('\n');

                // Last part may be incomplete → keep it for next time
                inputBuffer = lines[lines.Length - 1];

                // Process full lines
                for (int i = 0; i < lines.Length - 1; i++)
                {
                    string line = lines[i].Trim();

                    if (string.IsNullOrEmpty(line))
                        continue;

                    // Send to game logic (UP, DOWN, FIRE...)
                    DataReceived?.Invoke(line);

                    // Send to Serial Monitor
                    SerialMonitorReceived?.Invoke(line);
                }
                Console.WriteLine("RAW: " + incoming);

            }
            catch (Exception ex)
            {
                Log($"Read failed: {ex.Message}", Color.Red, "ERROR");
            }
        }

        //---------------------------------------------------------------
        //  Clean serial buffers
        //---------------------------------------------------------------
        public void CleanBuffer()
        {
            if (!serialPort.IsOpen)
            {
                Log("Port not open, nothing to clear.", Color.Orange, "WARNING");
                return;
            }

            serialPort.DiscardInBuffer();
            serialPort.DiscardOutBuffer();
            inputBuffer = "";

            Log("Buffer cleared.", Color.LawnGreen, "INFO");
        }

        //---------------------------------------------------------------
        //  Logging helper
        //---------------------------------------------------------------
        private void Log(string msg, Color color, string level)
        {
            if (loggingBox.InvokeRequired)
            {
                loggingBox.Invoke(new Action(() => Log(msg, color, level)));
                return;
            }

            loggingBox.SelectionColor = color;
            loggingBox.AppendText($"[{level}] {msg}\n");
            loggingBox.ScrollToCaret();
        }
    }
}