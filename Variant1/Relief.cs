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
        

        
        
        public int h_start;
        public double mstb;
        private bool Visible;
        private int [] ReliefHeight = new int[Program.MaxDistance + 1];

        public Relief()
        {
            ReBuild();
        }

        public int RHeight(int x)
        {
            return ReliefHeight[x];
        }
        public void Show()
        {
            Graphics g = Variant1.Form1.ActiveForm.CreateGraphics();
            Point P0 = new Point(0, h_start);
            Point P1 = new Point(2500, h_start);
            g.DrawLine(new Pen(Color.White), P0, P1);
            int    h=h_start;
            for ( int i= 1; i <= Program.MaxDistance/mstb; i++)
            {
                Point pt1 = new Point(i-1, h_start - ReliefHeight[Convert.ToInt32((i-1)*mstb)]);
                Point pt2 = new Point(i, h_start - ReliefHeight[Convert.ToInt32( i*mstb)]);
                g.DrawLine(new Pen(Color.GreenYellow), pt1,pt2);
            }
        }

        public void Clear()
        {
            Graphics g = Variant1.Form1.ActiveForm.CreateGraphics();
            for (int i = 1; i <= Program.MaxDistance / mstb; i++)
            {
                Point pt1 = new Point(i-1, h_start - ReliefHeight[Convert.ToInt32((i-1) * mstb)]);
                Point pt2 = new Point(i, h_start - ReliefHeight[Convert.ToInt32(i * mstb)]);
                g.DrawLine(new Pen(Form1.ActiveForm.BackColor), pt1, pt2);
            }
            Point P0 = new Point(0, h_start);
            Point P1 = new Point(2500, h_start);
            g.DrawLine(new Pen(Form1.ActiveForm.BackColor), P0, P1);
        }

        public void ReBuild()
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

        /*public int h_start { get; private set;}

public int Height(int x)
{
return ReliefHeight[x];

} 

public void ReliefBuilder()
{
int h = h_start, h_max = h, h_min = h;
int step = 1; // длина отрезка, которым рисуем рельеф в пикселях

int num, j = 0;
num = rc.right / step + 1;
int* ReliefHeight = new int[num];
for (int i = 0; i < rc.right; i = i + step)
{
int v1 = rand() % 3;
h = h + v1 - 1;
if (h < h_start - 200)
{
  h = 200;
}
if (h > h_start + 100)
{
  h = 500;
}
if (h > h_max)
{
  h_max = h;
}
if (h < h_min)
{
  h_min = h;
}
Relief[j] = h;
j++;
if (i == 0)
{
  h = h_start;
}
LineTo(hDC, i, h);
for (int k = 0; k < 1200000; k++)
{
}
}
int h_max_all = h_start - h_min;
int h_min_all = h_start - h_max;
}*/
    }
}
