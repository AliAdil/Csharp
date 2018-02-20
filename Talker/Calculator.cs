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
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        public string display = "";
        private void button1_Click(object sender, EventArgs e)
        {

             
             display = display + button2.Text;
             displayBox.Text = display;
             int two = Int32.Parse(button2.Text);
            
            

        }
        

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            display = display + button1.Text;
            displayBox.Text = display;
            int one = Int32.Parse(button1.Text);

           
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            string  clear = "READY FOR NEW CALCULATION";
            display = "";
            displayBox.Text = clear ;
        }

        private void multiplication_Click(object sender, EventArgs e)
        {
            display = display + multiplication.Text;
            displayBox.Text = display;
            
            
        }

        private void equal_Click(object sender, EventArgs e)
        {
          
        }
    }

    public class CalculatorMainMethod{
        
       
        

        public int Addition(int value1 , int value2)
        {
            int result = value1 + value2;
            return result;
        }

        
    }
}
