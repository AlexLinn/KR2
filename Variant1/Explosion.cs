using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Variant1
{
    public class Explosion
    {
        public int CoordX;
        public int CoordY;

        public void Show(int x, int y)
        {
            CoordX = x;
            CoordY = y;
            Graphics g = Variant1.Form1.ActiveForm.CreateGraphics();
            for (int i = 0; i < 10; i++)
            {
                g.FillEllipse(new SolidBrush(Color.Red), CoordX - i / 2, CoordY - i / 2, i, i);
                for (int j = 0; j < 100000; j++)
                {
                    for (int k = 0; k < 100; k++) { }
                }
            }
            for (int i = 0; i < 10; i++)
            {
                g.FillEllipse(new SolidBrush(Form1.ActiveForm.BackColor), CoordX - i / 2, CoordY - i / 2, i, i);
                for (int j = 0; j < 100000; j++)
                {
                    for (int k = 0; k < 100; k++) { }
                }
            }

        }


    }
}