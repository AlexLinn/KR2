using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Variant1
{
    

    public partial class Form1 : Form
    {
        public static Relief Relief1 = new Relief();
        Cannon Cannon1 = new Cannon();
        public static Panzer Panzer1 = new Panzer();
        public static Explosion Explosion1 = new Explosion();
        Traectory Traectory1 = new Traectory();
        public int h_start=0;
        
        public Form1()
        {
            InitializeComponent();
            
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        
        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            StatusBar.Items[0].Text = "Window size: " + Convert.ToString(ActiveForm.Width) + " x " + Convert.ToString(ActiveForm.Height);
            
        }
        
        private void Form1_Shown(object sender, EventArgs e)
        {
            StatusBar.Items[0].Text = "Window size: " + Convert.ToString(ActiveForm.Width) + " x " + Convert.ToString(ActiveForm.Height);
            Program.h_start = ActiveForm.Height - 250;
            Program.mstb = Convert.ToDouble( Program.MaxDistance)/ Convert.ToDouble(ActiveForm.Width);
            StatusBar.Items[1].Text = " mstb= " + Convert.ToString(Program.mstb);
            StatusBar.Items[2].Text = " MaxDistance= " + Convert.ToString(Program.MaxDistance);
            Random Distance = new Random();
            Relief1.Show();
            Panzer1.CoordX =  Distance.Next(900, Program.MaxDistance);
            Panzer1.CoordY = Program.h_start - Relief1.RHeight(Panzer1.CoordX);
            Panzer1.Show();
            StatusBar.Items[3].Text = " Panzer: X= " + Panzer1.CoordX + ", Y= " + Panzer1.CoordY ;
            Cannon1.CoordY = Program.h_start;
            Cannon1.CoordX = 0;
            Cannon1.Show();
            Traectory1.Speed = Convert.ToDouble(numericUpDownSpeed.Value);
            Traectory1.Angle = Convert.ToDouble(numericUpDownAngle.Value);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e) // About program
        {
            MessageBox.Show("Author: Ignashev V.A. \nGroup: PIT 15-1", "About program");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            //label3.Text = "X= " + e.X + ", " + Convert.ToInt32( Convert.ToDouble(e.X) * Program.mstb) + " Y=" + Relief1.RHeight(Convert.ToInt32(Convert.ToDouble(e.X) * Program.mstb)) +", " + e.Y;
        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            StatusBar.Items[0].Text = "Window size: " + Convert.ToString(ActiveForm.Width) + " x " + Convert.ToString(ActiveForm.Height);
            Relief1.Clear();
            Panzer1.Clear();
            Cannon1.Clear();
            Traectory1.Clear();
            Program.h_start = ActiveForm.Height - 250;
            Program.mstb = Convert.ToDouble(Program.MaxDistance) / Convert.ToDouble(ActiveForm.Width);
            Panzer1.CoordY = Program.h_start - Relief1.RHeight(Panzer1.CoordX);
            Relief1.Show();
            Panzer1.Show();
            StatusBar.Items[1].Text = "mstb= " + Convert.ToString(Program.mstb);
            StatusBar.Items[2].Text = "MaxDistance= " + Convert.ToString(Program.MaxDistance);
            StatusBar.Items[3].Text = " Panzer: X= " + Panzer1.CoordX + ", Y= " + Panzer1.CoordY;
            Cannon1.CoordY = Program.h_start;
            Cannon1.Show();
            Traectory1.Show();
        }

        private void changePanzerLocationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void changeReliefToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Relief1.Clear();
            Panzer1.Clear();
            Cannon1.Clear();
            Relief1.ReBuild();
            Relief1.Show();
            Random Distance = new Random();
            Panzer1.CoordX = Distance.Next(900, Program.MaxDistance);
            Panzer1.CoordY = Program.h_start - Relief1.RHeight(Panzer1.CoordX);
            StatusBar.Items[3].Text = " Panzer: X= " + Panzer1.CoordX + ", Y= " + Panzer1.CoordY;
            Panzer1.Show();
            Cannon1.Show();
            
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            label3.Text = "X= " + e.X + ", " + Convert.ToInt32(Convert.ToDouble(e.X) * Program.mstb) + " Y=" + Relief1.RHeight(Convert.ToInt32(Convert.ToDouble(e.X) * Program.mstb)) + ", " + e.Y;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool Res = Traectory1.Show( );
            if (Res)
            {
                label4.Visible = true;
            }
            
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        

        private void numericUpDownAngle_ValueChanged(object sender, EventArgs e)
        {
            Traectory1.Clear();
            Traectory1.Angle = Convert.ToDouble(numericUpDownAngle.Value);
        }

        private void numericUpDownSpeed_ValueChanged_1(object sender, EventArgs e)
        {
            Traectory1.Clear();
            Traectory1.Speed = Convert.ToDouble(numericUpDownSpeed.Value);
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label4.Visible = false;
            Traectory1.Clear();
            Relief1.Clear();
            Panzer1.Clear();
            Cannon1.Clear();
            Relief1.ReBuild();
            Relief1.Show();
            Random Distance = new Random();
            Panzer1.CoordX = Distance.Next(900, Program.MaxDistance);
            Panzer1.CoordY = Program.h_start - Relief1.RHeight(Panzer1.CoordX);
            StatusBar.Items[3].Text = " Panzer: X= " + Panzer1.CoordX + ", Y= " + Panzer1.CoordY;
            Panzer1.Show();
            Cannon1.Show();

        }
    }
    
}
