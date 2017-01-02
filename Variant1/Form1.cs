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
        Relief Relief1 = new Relief();
        Cannon Cannon1 = new Cannon();
        Panzer Panzer1 = new Panzer();
        public int h_start=0;
        
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            Panzer1.Show();
            
        }
        
        

        private void button2_Click(object sender, EventArgs e)
        {
            Cannon1.CoordX= 0;
            Cannon1.CoordY = Program.h_start;
            Cannon1.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Relief1.Clear();
        }

        
        private void Form1_SizeChanged(object sender, EventArgs e)
        {
             
                
                
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
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Author: Ignashev V.A. \nGroup: PIT 15-1", "About program");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Relief1.Show();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            //label3.Text = "X= " + e.X + ", " + Convert.ToInt32( Convert.ToDouble(e.X) * Program.mstb) + " Y=" + Relief1.RHeight(Convert.ToInt32(Convert.ToDouble(e.X) * Program.mstb)) +", " + e.Y;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            StatusBar.Items[0].Text = "Window size: " + Convert.ToString(ActiveForm.Width) + " x " + Convert.ToString(ActiveForm.Height);
            Relief1.Clear();
            Panzer1.Clear();
            Program.h_start = ActiveForm.Height - 250;
            Program.mstb = Convert.ToDouble(Program.MaxDistance) / Convert.ToDouble(ActiveForm.Width);
            Panzer1.CoordY = Program.h_start - Relief1.RHeight(Panzer1.CoordX);
            Relief1.Show();
            Panzer1.Show();
            StatusBar.Items[1].Text = "mstb= " + Convert.ToString(Program.mstb);
            StatusBar.Items[2].Text = "MaxDistance= " + Convert.ToString(Program.MaxDistance);
            StatusBar.Items[3].Text = " Panzer: X= " + Panzer1.CoordX + ", Y= " + Panzer1.CoordY;
        }

        private void changePanzerLocationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void changeReliefToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Relief1.Clear();
            Panzer1.Clear();
            Relief1.ReBuild();
            Relief1.Show();
            Random Distance = new Random();
            Panzer1.CoordX = Distance.Next(900, Program.MaxDistance);
            Panzer1.CoordY = Program.h_start - Relief1.RHeight(Panzer1.CoordX);
            StatusBar.Items[3].Text = " Panzer: X= " + Panzer1.CoordX + ", Y= " + Panzer1.CoordY;
            Panzer1.Show();
            
            
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            label3.Text = "X= " + e.X + ", " + Convert.ToInt32(Convert.ToDouble(e.X) * Program.mstb) + " Y=" + Relief1.RHeight(Convert.ToInt32(Convert.ToDouble(e.X) * Program.mstb)) + ", " + e.Y;
        }
    }
    
}
