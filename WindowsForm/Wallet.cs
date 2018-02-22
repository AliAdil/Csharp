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
    public partial class Wallet : Form
    {
        Guy joe;
        Guy bob;
        Guy ali;
        
        int bank = 100;

        public void UpdateForm()
        {
            aliCashLabel.Text = ali.Name + " has $" + ali.cash + " take cash from bank";
            joesCashLabel.Text = joe.Name + " has $" + joe.cash;
            bobsCashLabel.Text = bob.Name + " has $" + bob.cash;
            bankCashLabel.Text = "The bank has $" + bank;
        }


        public Wallet()
        {
            InitializeComponent();
            joe = new Guy();
            joe.Name = "Joe";
            joe.cash = 50;

            bob = new Guy();
            bob.Name = "Bob";
            bob.cash = 100;

            ali = new Guy();
            ali.Name = "Ali";
            ali.cash = 0;

            UpdateForm();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (bank >= 10 || bank >= 1)
            {
                bank -= joe.ReceiveCash(10);
                UpdateForm();
            }
            else
            {
                MessageBox.Show("The bank is out of money.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bank += bob.GiveCash(5);
            UpdateForm();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (bank >= 30  || bank >= 1)
            {
                bank -= ali.ReceiveCash(30);
               
                UpdateForm();
            }

            
            else
            {
                MessageBox.Show("The bank is out of money.");
            }
             
            bank += bob.GiveCash(30);
            bank += joe.GiveCash(30);
            if (bob.cash >= 10 || joe.cash >= 10)
            {
                bank += bob.GiveCash(10);
                bank += joe.GiveCash(10);

            }
            
            
            UpdateForm();
        }

        
    }
}
