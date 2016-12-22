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
        public int CoordPX;
        public int CoordPY;
        private int Width = 8;
        private int Height = 4;
        public void PShow()
        {
            Graphics g = Variant1.Form1.ActiveForm.CreateGraphics();
            g.FillEllipse(new SolidBrush(Color.DarkBlue), CoordPX, CoordPY, Width, Height);
            g.FillEllipse(new SolidBrush(Color.DarkBlue), CoordPX + 2, CoordPY - 2, Height, Height);

        }
        public void PClear()
        {
            Graphics g = Variant1.Form1.ActiveForm.CreateGraphics();
            g.FillEllipse(new SolidBrush(Form1.DefaultBackColor), CoordPX, CoordPY, Width, Height);
            g.FillEllipse(new SolidBrush(Form1.DefaultBackColor), CoordPX + 2, CoordPY - 2, Height, Height);
        }
        public Panzer()
        {

            CoordPX = 0;
            CoordPY = 0;
        }
        public Panzer(int x, int y)
        {

            CoordPX = x;
            CoordPY = y;
        }


    }
}
