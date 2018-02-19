using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm
{
    public partial class FlashyThing : Form
    {
        public FlashyThing()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a=2 , b= 3;
            int d = a*b;
            String y = d.ToString();
           
            multi.Text = y;
            test.Text = "My Name is Tofeeq";
            while(Visible)
            {
                
            
            for(int c = 0; c <254 && Visible ; c++){
            this.BackColor = Color.FromArgb(c, 255-c, c);
            Application.DoEvents();
            System.Threading.Thread.Sleep(3);
            }

            for (int c = 254; c > 0 && Visible ; c--)
            {
                this.BackColor = Color.FromArgb(c, 255 - c, c);
                Application.DoEvents();
                System.Threading.Thread.Sleep(30);
            }

           
            }
        }
    }
}
