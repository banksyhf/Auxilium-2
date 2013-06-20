using System.Drawing;
using System.Windows.Forms;

namespace Auxilium.Controls
{
    internal sealed class SmoothLabel : Control
    {
        private readonly Bitmap _textBitmap;

        private readonly Graphics _textGraphics;

        public SmoothLabel()
        {
            SetStyle((ControlStyles)139270, true);

            _textBitmap = new Bitmap(1, 1);
            _textGraphics = Graphics.FromImage(_textBitmap);

            BackColor = Color.FromArgb(250, 250, 200);
            ForeColor = Color.FromArgb(150, 150, 120);
            _p1 = new Pen(Color.FromArgb(200, 200, 160));
        }

        private Pen _p1 = Pens.Black;

        public Color BorderColor
        {
            get { return _p1.Color; }
            set
            {
                _p1 = new Pen(value);
                Invalidate();
            }
        }

        private SolidBrush _b1;

        public override Color ForeColor
        {
            get { return base.ForeColor; }
            set
            {
                base.ForeColor = value;
                _b1 = new SolidBrush(value);
                Invalidate();
            }
        }

        private Size _textSize;

        public override string Text
        {
            get { return base.Text; }
            set
            {
                base.Text = value;
                _textSize = _textGraphics.MeasureString(base.Text, base.Font).ToSize();
                Invalidate();
            }
        }

        public override Font Font
        {
            get { return base.Font; }
            set
            {
                base.Font = value;
                _textSize = _textGraphics.MeasureString(base.Text, base.Font).ToSize();
                Invalidate();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.Clear(BackColor);
            e.Graphics.DrawString(Text, Font, _b1, Width / 2 - _textSize.Width / 2, Height / 2 - _textSize.Height / 2);
            e.Graphics.DrawRectangle(_p1, 0, 0, Width - 1, Height - 1);
        }
    }
}