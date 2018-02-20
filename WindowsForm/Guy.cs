using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace WindowsForm
{
    class Guy
    {
        public string Name;
        public int cash;

        public int GiveCash(int amount)
        {
            if (amount <= cash && amount > 0)
            {
                cash -= amount;
                return amount;
            }
            else
            {
                MessageBox.Show("I don't have enough cash to give you" + amount , Name + " Says..");
                return 0;
            }
        }

        public int ReceiveCash(int amount)
        {
            if (amount > 0)
            {
                cash += amount;
                return amount;
            }
            else
            {
                MessageBox.Show(amount + " isn't an amount i will take", Name + " says..");
                return 0;

            }
        }
    }
}
