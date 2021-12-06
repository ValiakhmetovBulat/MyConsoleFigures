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
    abstract public class Figure
    {
        public int x;
        public int y;
        public int w;
        public int h;
        public int y1;
        public int x1;
        public string name;
      
        abstract public void Draw();
        abstract public void MoveTo(int x, int y);
        abstract public void ChangeSize(int x, int y, int ch, int w, int h);

       
        public void Clear()
        {
            Graphics g = Graphics.FromImage(Init.bitmap);
            g.Clear(Color.Black);
        }
        public void DeleteF(Figure figure, bool flag = true)
        {
            if (flag == true)
            {
                Graphics g = Graphics.FromImage(Init.bitmap);
                ShapeContainer.figureList.Remove(figure);
                this.Clear();
                Init.pictureBox.Image = Init.bitmap;
                foreach (Figure f in ShapeContainer.figureList)
                {
                    f.Draw();
                }
            }
            else
            {
                Graphics g = Graphics.FromImage(Init.bitmap);
                ShapeContainer.figureList.Remove(figure);
                this.Clear();
                Init.pictureBox.Image = Init.bitmap;
                foreach (Figure f in ShapeContainer.figureList)
                {
                    f.Draw();
                }
                ShapeContainer.figureList.Add(figure);
                
            }
        }
        
    }
}
