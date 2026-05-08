using System;
using System.Drawing;
using System.Windows.Forms;

namespace Astroidinator_SDE2025_Jkra
{
    internal class csSlideshow
    {
        // ── SLIDE DATA ─────────────────────────────────────────────
        private readonly string[] imagePaths =
        {
            "images/slide1.png",  // Helios One, bodies
            "images/slide2.png",  // NCR troops/Survivors after Sunburst
            "images/slide3.png",  // Fantastic
            "images/slide4.png",  //  Brotherhood retreating from Helios One
            "images/slide5.png",  // Legion on the march
            "images/slide6.png",  // Legionnaires
            "images/slide7.png",  // Caesar
            "images/slide8.png",  // Malpais Legate 
            "images/slide9.png"   // Hoover Dam front view
        };

        private readonly string[] captions =
        {
            "Many young men and women of the NCR assaulted Helios One.\nThe survivors had to decide if it was worth it.",
            "Many saw it as both a great victory and a morale boost. \n However the reality was much different...",
            "For years the NCR tried to use Helios One,\nbut they could never harness its true potential.",
            "The Brotherhood wasn't the first of NCR's problems in the Mojave.....",
            "For a new great power was on the rise in the east, stretching far, and wide beyond the river.",
            "The Legion. \n A vast, disciplined army, seasoned by decades of qonquest.",
            "Caesar, the conqueror of 87 tribes, and the son of Mars\nwas already on the march.",
            "He sent forth his most expirienced, skilled and seasoned legate, \n co-founder of the Legion and Caesar's oldest friend. \n The legendary, Malpais Legate.",
            "His sights, set firmly on Hoover Dam."
        };

        // ── STATE ──────────────────────────────────────────────────
        private int currentSlide = 0;
        private bool isRunning = false;
        private Image[] slides;

        // ── UI ─────────────────────────────────────────────────────
        private readonly Panel displayPanel;
        private readonly Timer slideTimer;
        private readonly Label captionLabel;

        // ── EVENT — fires when slideshow ends ──────────────────────
        public event Action SlideshowFinished;

        public csSlideshow(Panel panel)
        {
            displayPanel = panel;
            displayPanel.Paint += OnPaint;

            // Load images
            slides = new Image[imagePaths.Length];
            for (int i = 0; i < imagePaths.Length; i++)
            {
                try { slides[i] = Image.FromFile(imagePaths[i]); }
                catch { slides[i] = null; }
            }

            // Caption label overlaid on panel
            captionLabel = new Label
            {
                AutoSize = false,
                TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
                ForeColor = Color.White,
                BackColor = Color.FromArgb(160, 0, 0, 0), // semi-transparent black
                Font = new Font("Georgia", 13, FontStyle.Italic),
                Dock = DockStyle.Bottom,
                Height = 80
            };
            displayPanel.Controls.Add(captionLabel);

            // Timer — 7.5 seconds per slide
            slideTimer = new Timer { Interval = 7500 };
            slideTimer.Tick += OnSlideTimer;
        }

        // ── START ──────────────────────────────────────────────────
        public void Start()
        {
            currentSlide = 0;
            isRunning = true;
            ShowSlide(0);
            slideTimer.Start();
        }

        public void Stop()
        {
            slideTimer.Stop();
            isRunning = false;
        }

        // ── ADVANCE ────────────────────────────────────────────────
        private void OnSlideTimer(object sender, EventArgs e)
        {
            currentSlide++;
            if (currentSlide >= slides.Length)
            {
                Stop();
                SlideshowFinished?.Invoke();
                return;
            }
            ShowSlide(currentSlide);
        }

        private void ShowSlide(int index)
        {
            captionLabel.Text = captions[index];
            displayPanel.Invalidate();
        }

        // ── PAINT ──────────────────────────────────────────────────
        private void OnPaint(object sender, PaintEventArgs e)
        {
            if (!isRunning) return;

            Graphics g = e.Graphics;
            g.Clear(Color.Black);

            Image img = slides[currentSlide];
            if (img != null)
                g.DrawImage(img, 0, 0,
                    displayPanel.Width,
                    displayPanel.Height);
        }

        public bool IsRunning() => isRunning;
    }
}