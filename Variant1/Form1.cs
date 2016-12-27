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
        Panzer Panzer1 = new Panzer();
        Cannon Cannon1 = new Cannon();
        Relief Relief1 = new Relief();
        public int h_start=0;
        
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int PX = Convert.ToInt32(textBox1.Text);
            int PY = Convert.ToInt32(textBox2.Text);
            Panzer1.CoordPX = PX;
            Panzer1.CoordPY = PY;
            Panzer1.PShow();
            StatusBar.Items[1].Text = "Panzer: " + Convert.ToString(PX) + ", " + Convert.ToString(PY);

            //Graphics g = this.CreateGraphics();
            //g.DrawLine(new Pen(Color.Red), 10, 10, 100, 100);
            //g.DrawEllipse(new Pen(Color.Blue), 25, 25, 35, 75);
        }
        
        

        private void button2_Click(object sender, EventArgs e)
        {
            Cannon1.CoordCX= 0;
            Cannon1.CoordCY = Relief1.h_start;
            Cannon1.CShow();
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
            
            Relief1.h_start = ActiveForm.Height - 250;
            Relief1.mstb = Convert.ToDouble( Program.MaxDistance)/ Convert.ToDouble(ActiveForm.Width);
            StatusBar.Items[1].Text = "mstb= " + Convert.ToString(Relief1.mstb);
            StatusBar.Items[2].Text = "MaxDistance= " + Convert.ToString(Program.MaxDistance);
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
            label3.Text = "X= " + e.X + ", " + Convert.ToInt32( Convert.ToDouble(e.X) * Relief1.mstb) + " Y=" + Relief1.RHeight(Convert.ToInt32(Convert.ToDouble(e.X) * Relief1.mstb)) +", " + e.Y;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Relief1.Clear();
            Relief1.ReBuild();
            Relief1.Show();
        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            StatusBar.Items[0].Text = "Window size: " + Convert.ToString(ActiveForm.Width) + " x " + Convert.ToString(ActiveForm.Height);
            Relief1.Clear();
            Relief1.h_start = ActiveForm.Height - 250;
            Relief1.mstb = Convert.ToDouble(Program.MaxDistance) / Convert.ToDouble(ActiveForm.Width);
            Relief1.Show();
            StatusBar.Items[1].Text = "mstb= " + Convert.ToString(Relief1.mstb);
            StatusBar.Items[2].Text = "MaxDistance= " + Convert.ToString(Program.MaxDistance);
        }
    }
    
}
