using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Csharp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            string name = "Ali Adil";
            int x = 3;
            x = x * 3;
            double d = Math.PI / 2;
            myLabel.Text = "name is " + name + "\nx is "+ x + "\nd is "+ d;
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            int x = 5;
            if (x == 10)
            {
                myLabel.Text = "x Must be 10";
            }
            else
            {
                myLabel.Text = "x isn't 10";
            }
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            int someValue = 3;
            string name = "Ali Adil";
            if((someValue == 3)&& (name== "joe")){

                myLabel.Text = "x is 3 and the name is Joe";

            }
            myLabel.Text= "this line runs no matter what ";
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            //    int count = 0;
            //    while (count < 10)
            //    {
            //        count = count + 1;
            //    }
            //    for (int i = 0; i < 5; i++)
            //    {
            //        count = count - 1; 

            //    }
            //    myLabel.Text = "The Answer is " + count;
            //}

            //int count = 5;
            //while (count > 0)
            //{

            //    count = count * 3;
            //    count = count * -1;
            //}
            //int j = 2;
            //for (int i = 1; i < 100;  i = i * 2)
            //{
            //    j = j - 1;
            //    while (j < 25)
            //    {
            //        j = j + 5; 
            //    }
            //}

            //int p = 2;

            //for (int q = 2; q < 32; q= q *2)
            //{
            //    while (p<q)
            //    {
            //        p = p * 2;
            //    }

            //    q = p - q;
            //}
            // infinite loop 
            //while (true)
            //{
            //    int i = 1; 
            //}
            // infinite looop 

            //int i = 0;
            //int count = 2;
            //while (i == 0)
            //{
            //    count = count * 3;
            //    count = count * -1; 
            //}

            int x = 3 ; 
            string result = "";

            while (x > 0)
            {
                if (x > 2)
                {
                    result = result + "a";
                }
                x = x - 1;
                result = result + "-";

                if (x == 2)
                {
                    result = result + "b c";
                }


                if (x == 1)
                {
                    result = result + "d";
                    x = x - 1;
                }
            }
           

            


            myLabel.Text = result;



            


        }

        
    }
}
