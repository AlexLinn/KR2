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
        public int CoordCX;
        public int CoordCY;
        private int Width = 10;
        private int Height = 5;

        public void CShow()
        {
            Graphics g = Variant1.Form1.ActiveForm.CreateGraphics();
            g.FillRectangle(new SolidBrush(Color.Green), CoordCX, CoordCY - Height, Width, Height);
            g.FillRectangle(new SolidBrush(Color.Blue), CoordCX, CoordCY, Width, Height);

        }
        public void CClear()
        {
            Graphics g = Variant1.Form1.ActiveForm.CreateGraphics();
            g.FillRectangle(new SolidBrush(Form1.DefaultBackColor), CoordCX, CoordCY - Height, Width, Height * 2);
        }
        public Cannon()
        {

            CoordCX = 0;
            CoordCY = 0;
        }
    }
}
