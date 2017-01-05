using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;



namespace Variant1
{
    public class Traectory
    {
        public double Speed;
        public double Angle;
        private bool Visible=false;
        double pi = 3.14159;

        public Traectory()
        {
            
        }
    
        public bool Show()
        {
            double  time_fly = 0;
            int dy = Program.h_start, dx = 0, D_X = 0;
            
            Graphics g = Variant1.Form1.ActiveForm.CreateGraphics();
            
            Point pt1 = new Point(0, Program.h_start);
            for ( dx = 1; dx <= Program.MaxDistance / Program.mstb; dx++)
            {
                //time_fly = time_fly + 0.05;
                // dx = Convert.ToInt32(Speed * time_fly * Math.Cos(Angle * pi / 180)) ;
                time_fly = dx * Program.mstb/ (Speed* Math.Cos(Angle * pi / 180));
                dy = Program.h_start - (Convert.ToInt32(Speed * time_fly * Math.Sin(Angle * pi / 180) - 9.81 * time_fly * time_fly / 2));

                D_X = Program.h_start - Form1.Relief1.RHeight(Convert.ToInt32( Convert.ToDouble( dx)*Program.mstb));
                
                if ( dy > D_X )
                {
                    
                    break;
                }

                Point pt2 = new Point(dx, dy );
                g.DrawLine(new Pen(Color.Brown), pt1, pt2);
                pt1 = pt2;
            }
            Form1.Explosion1.Show(dx, dy);
            Visible = true;
            if (Form1.Panzer1.CoordX - 3 < dx*Program.mstb && dx*Program.mstb < Form1.Panzer1.CoordX+3) {
                return true;
            }
            Form1.Panzer1.Show();
            return false;
            
            
            
        }

        public void Clear()
        {
            if (Visible)
            {
                Graphics g = Variant1.Form1.ActiveForm.CreateGraphics();
                double  time_fly = 0;
                int dy = Program.h_start, dx = 0, D_X = 0;
                Point pt1 = new Point(0, Program.h_start);
                for (dx = 1; dx <= Program.MaxDistance / Program.mstb; dx++)
                {
                    //time_fly = time_fly + 0.05;
                    // dx = Convert.ToInt32(Speed * time_fly * Math.Cos(Angle * pi / 180)) ;
                    time_fly = dx * Program.mstb / (Speed * Math.Cos(Angle * pi / 180));
                    dy = Program.h_start - (Convert.ToInt32(Speed * time_fly * Math.Sin(Angle * pi / 180) - 9.81 * time_fly * time_fly / 2));

                    D_X = Program.h_start - Form1.Relief1.RHeight(Convert.ToInt32(Convert.ToDouble(dx) * Program.mstb));
                    
                    if (dy > D_X)
                    {

                        break;
                    }

                    Point pt2 = new Point(dx, dy);
                    g.DrawLine(new Pen(Form1.ActiveForm.BackColor), pt1, pt2);
                    pt1 = pt2;
                }
            }
            Visible = false;
        }
    }
}