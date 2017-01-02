using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace Variant1
{
    class  Relief
    {
         // масштаб, м/пиксель
        private bool Visible;  
        private int [] ReliefHeight = new int[Program.MaxDistance + 1]; 
        public Relief()
        {
            ReBuild();
        }
        public int RHeight(int x) // Возвращает дельту высоты в заданной координету Х.
        {
            return ReliefHeight[x];
        }
        public void Show()  // Рисует рельеф на форме
        {
            Graphics g = Variant1.Form1.ActiveForm.CreateGraphics();
            Point P0 = new Point(0, Program.h_start);
            Point P1 = new Point(2500, Program.h_start);
            g.DrawLine(new Pen(Color.White), P0, P1);
            int    h= Program.h_start;
            for ( int i= 1; i <= Program.MaxDistance/ Program.mstb; i++)
            {
                Point pt1 = new Point(i-1, Program.h_start - ReliefHeight[Convert.ToInt32((i-1)* Program.mstb)]);
                Point pt2 = new Point(i, Program.h_start - ReliefHeight[Convert.ToInt32( i* Program.mstb)]);
                g.DrawLine(new Pen(Color.GreenYellow), pt1,pt2);
            }
            Visible = true;
        }
        public void Clear()  // Удалаяет нарисованый рельеф с формы
        {
            Graphics g = Variant1.Form1.ActiveForm.CreateGraphics();
            for (int i = 1; i <= Program.MaxDistance / Program.mstb; i++)
            {
                Point pt1 = new Point(i-1, Program.h_start - ReliefHeight[Convert.ToInt32((i-1) * Program.mstb)]);
                Point pt2 = new Point(i, Program.h_start - ReliefHeight[Convert.ToInt32(i * Program.mstb)]);
                g.DrawLine(new Pen(Form1.ActiveForm.BackColor), pt1, pt2);
            }
            Point P0 = new Point(0, Program.h_start);
            Point P1 = new Point(2500, Program.h_start);
            g.DrawLine(new Pen(Form1.ActiveForm.BackColor), P0, P1);
            Visible = false;
        }
        public void ReBuild()  // Расчитывает новый рельеф
        {
            DateTime dt = TimeZoneInfo.ConvertTimeToUtc(DateTime.Now);
            DateTime dt1970 = new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            TimeSpan tsInterval = dt.Subtract(dt1970);
            Random rand = new Random(Convert.ToInt32(tsInterval.TotalSeconds));

            int j = 0, h = 0;
            int h_max = h, h_min = h;
            ReliefHeight[0] = 0;
            for (int i = 1; i <= Program.MaxDistance; i++)
            {
                int v1 = rand.Next(-1, 2);
                h = h + v1;
                if (h < -200)
                {
                    h = -200;
                }
                if (h > 100)
                {
                    h = 100;
                }
                if (h > h_max)
                {
                    h_max = h;
                }
                if (h < h_min)
                {
                    h_min = h;
                }
                ReliefHeight[j] = h;
                j++;
                if (i == 0)
                {
                    h = 0;
                }


            }
            int h_max_all = -h_min;
            int h_min_all = h_max;
        }
    }
}
