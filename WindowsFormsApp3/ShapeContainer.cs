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
    class ShapeContainer
    {
        public static List <Figure> figureList = new List<Figure>();

        public static void AddFigure(Figure figure)
        {
            figureList.Add(figure);
        }

        public static Figure FindFigure(string name)
        {
            foreach(Figure f in figureList)
            {
                if (f.name == name)
                {
                    return f;
                }
            }
            return null;
        }
    }
}
