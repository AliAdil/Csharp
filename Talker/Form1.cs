using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Talker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Talker talkerWho = new Talker();
            int len = Talker.blahblahblah(textBox1.Text, (int)numericUpDown1.Value);
            MessageBox.Show("The message length is " + len);
        }
    }
}
