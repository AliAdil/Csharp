using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TypesAndRefrences
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //decimal myDecimalValue = 10;
            //int myIntValue = (int)myDecimalValue;
            int myInt = 10;

            byte myByte = (byte)myInt;

            double myDouble = (double)myByte;
            
            //unable to convert
            //bool myBool = (bool) myDouble;
           
            string myString = "false";

            //unable to convert
            //myBool = (bool)myString;

            //unable to convert
            //myString = (string)myInt;

            myString = myInt.ToString();

            //unable to convert
            //myBool = (bool)myByte;

            //unbale to convert
            //myByte = (byte)myBool;

            short myShort = (short)myInt;

            //unable to convert
            char myChar = 'x';
            //myString = (string) myChar;

            long myLong = (long)myInt;

            decimal myDecimal = (long)myLong;

            int myInt2 = 36;
            float myFloat = 16.0f;
            myFloat = myInt2 * myFloat; 

            myString = myString + myInt + myByte + myDouble + myChar; 
            MessageBox.Show("The value is " +myFloat);


            long l = 139401930;
            short s = 516;
            double d = l - s;
            d = d / 123.456;
            MessageBox.Show("The Answer is " + d);

            
        }

    }
}
