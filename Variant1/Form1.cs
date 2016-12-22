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
            Cannon1.CoordCX= Convert.ToInt32(textBox1.Text);
            Cannon1.CoordCY = Convert.ToInt32(textBox2.Text);
            Cannon1.CShow();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Cannon1.CClear();
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            StatusBar.Items[0].Text = "Window size: " + Convert.ToString(ActiveForm.Width) + " x " + Convert.ToString(ActiveForm.Height);
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            StatusBar.Items[0].Text = "Window size: " + Convert.ToString(ActiveForm.Width) + " x " + Convert.ToString(ActiveForm.Height);
        }
    }
    
}
