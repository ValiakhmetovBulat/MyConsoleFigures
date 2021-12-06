using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public class Ellipse : Figure
    {
        public Ellipse(string name, int x, int y, int w, int h)
        {
            this.x = x;
            this.y = y;
            this.w = w;
            this.h = h;
            this.name = name;
        }

        public Ellipse() { }

        public override void Draw()
        {
            Graphics g = Graphics.FromImage(Init.bitmap);
                g.DrawEllipse(Init.pen, this.x, this.y, this.w, this.h);
                Init.pictureBox.Image = Init.bitmap;
        }
        //782;591
        public override void MoveTo(int x, int y)
        {
            if (!((this.x + x < 0 && this.y + y < 0)
                || (this.y + y < 0)
                || (this.x + x > Init.pictureBox.Width && this.y + y < 0)
                || (this.x + this.w + x > Init.pictureBox.Width)
                || (this.x + x > Init.pictureBox.Width && this.y + y > Init.pictureBox.Height)
                || (this.y + this.h + y > Init.pictureBox.Height)
                || (this.x + x < 0 && this.y + y > Init.pictureBox.Height)
                || (this.x + x < 0)))
            {
                this.x += x;
                this.y += y;
                DeleteF(this, false);
                Draw();
            }
        }
        public override void ChangeSize(int x, int y, int ch, int w, int h)
        {
            if (!((this.x + ch < 0 && this.y + ch < 0)
               || (this.y + ch < 0)
               || (this.x + ch > Init.pictureBox.Width && this.y + ch < 0)
               || (this.x + this.w + ch > Init.pictureBox.Width)
               || (this.x + ch > Init.pictureBox.Width && this.y + ch > Init.pictureBox.Height)
               || (this.y + this.h + ch > Init.pictureBox.Height)
               || (this.x + ch < 0 && this.y + ch > Init.pictureBox.Height)
               || (this.x + ch < 0) 
               || (this.h + ch <= 0)
               || (this.w + ch <= 0) ))
            {
                this.w += ch;
                this.h += ch;
                DeleteF(this, false);
                Draw();
            }
        }
    }
}
