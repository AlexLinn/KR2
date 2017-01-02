using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Variant1
{
    class Panzer
    {
        public int CoordX;
        public int CoordY;
        private int Width = 8;
        private int Height = 4;
        public void Show()
        {
            Graphics g = Variant1.Form1.ActiveForm.CreateGraphics();
            g.FillEllipse(new SolidBrush(Color.DarkBlue), Convert.ToInt32(Convert.ToDouble(CoordX) / Program.mstb)-4, CoordY-1, Width, Height);
            g.FillEllipse(new SolidBrush(Color.DarkBlue), Convert.ToInt32(Convert.ToDouble(CoordX) / Program.mstb) -2, CoordY -3 , Height, Height);
        }
        public void Clear()
        {
            Graphics g = Variant1.Form1.ActiveForm.CreateGraphics();
            g.FillEllipse(new SolidBrush(Form1.ActiveForm.BackColor), Convert.ToInt32(Convert.ToDouble(CoordX) / Program.mstb)-4, CoordY-1, Width, Height);
            g.FillEllipse(new SolidBrush(Form1.ActiveForm.BackColor), Convert.ToInt32(Convert.ToDouble(CoordX) / Program.mstb) -2, CoordY -3 , Height, Height);
            
        }
        public Panzer()
        {

        }
        public Panzer(int x, int y)
        {
            CoordX = x;
            CoordY = y;
        }


    }
}
