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
        int bank = 100;

        public void UpdateForm()
        {
            joesCashLabel.Text = joe.Name + " has $" + joe.cash;
            bobsCashLabel.Text = bob.Name + " has $" + bob.cash;
            bankCashLabel.Text = "The bank has $" + bank;
        }


        public Wallet()
        {
            InitializeComponent();
        }

        
    }
}
