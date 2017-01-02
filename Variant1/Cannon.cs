using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Variant1
{
    class Cannon
    {
        public int CoordX;
        public int CoordY;
        private int Width = 10;
        private int Height = 5;

        public void Show()
        {
            Graphics g = Variant1.Form1.ActiveForm.CreateGraphics();
            g.FillRectangle(new SolidBrush(Color.Yellow), CoordX, CoordY - Height, Width, Height);
            g.FillRectangle(new SolidBrush(Color.Blue), CoordX, CoordY, Width, Height);

        }
        public void Clear()
        {
            Graphics g = Variant1.Form1.ActiveForm.CreateGraphics();
            g.FillRectangle(new SolidBrush(Form1.ActiveForm.BackColor), CoordX, CoordY - Height, Width, Height * 2);
        }
        public Cannon()
        {

            CoordX = 0;
            CoordY = 0;
        }
    }
}
