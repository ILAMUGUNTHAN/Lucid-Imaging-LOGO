using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Lucid_Imaging_Logo
{
    public partial class logo : UserControl
    {
        public logo()
        {
            InitializeComponent();
            this.BackColor = Color.DodgerBlue;
            this.Size = new Size(250, 250);
        }

        

        private void OnPaint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            this.BackColor = Color.FromArgb(13,98,177);

            Point[] topRightTriangle =
            {
                new Point(-1,-1),
                new Point(-1,Width/2),
                new Point(Height/2,-1)

            };
            Point[] topLeftTriangle =
            {
                new Point(Width/2,-1),
                new Point(Width,-1),
                new Point(Width,Height/2)

            };

            Point[] star =
            {
                new Point((int)(Width/16.6666),(int)(Height/2.5)),
                new Point((int)(Width/1.8115),(int)(Height/2.6041)),
                new Point((int)(Width/2.9411),(int)(Height/6.7567)),
                new Point((int)(Width/1.7361),(int)(Height/2.7777)),
                new Point((int)(Width/1.6778),(int)(Width/13.8888)),
                new Point((int)(Width/1.6447),(int)(Width/2.7777)),
                new Point((int)(Width/1.2820),(int)(Width/4.7169)),
                new Point((int)(Width/1.5923),(int)(Width/2.6315)),
                new Point((int)(Width/1.0162),(int)(Width/2.5511)),
                new Point((int)(Width/1.5923),(int)(Width/2.4271)),
                new Point((int)(Width/1.1904),(int)(Width/1.5625)),
                new Point((int)(Width/1.6447),(int)(Width/2.3148)),
                new Point((int)(Width/1.6891),(int)(Width/1.1467)),
                new Point((int)(Width/1.7241),(int)(Width/2.3148)),
                new Point((int)(Width/3.2894),(int)(Width/1.4367)),
                new Point((int)(Width/1.7857),(int)(Width/2.4271)),
                new Point((int)(Width/16.6666),(int)(Height/2.5))


            };
            
            g.FillPolygon(new SolidBrush(Color.White), topRightTriangle);
            g.FillPolygon(new SolidBrush(Color.White), topLeftTriangle);

            Rectangle rightEllipse = new Rectangle((Width/2 - Width/10),(Height*8/20)+Height/50 ,Width*2,Height*2); 
            g.FillEllipse(new SolidBrush(Color.White),rightEllipse);

            Rectangle leftEllipse = new Rectangle(-Width*3/2 +Width/10, Height*8/20, Width*2, Height*2);
            g.FillEllipse(new SolidBrush(Color.White), leftEllipse);

            g.FillPolygon(new SolidBrush(Color.White), star);


        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            Width = Height = Math.Min(Width, Height);
        }
    }
}
