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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace DC_Calculator
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

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            double x = 0, i = 0;
            x = Convert.ToDouble(num1.Text);
            i = Convert.ToDouble(num2.Text);
            double ans = x + i;
            Ans.Text = "Ans is: " + ans;
        }

        private void Subtract_Click(object sender, RoutedEventArgs e)
        {
            double x = 0, i = 0;
            x = Convert.ToDouble(num1.Text);
            i = Convert.ToDouble(num2.Text);
            double ans = x - i;
            Ans.Text = "Ans is: " + ans;
        }

        private void Multiply_Click(object sender, RoutedEventArgs e)
        {
            double x = 0, i = 0;
            x = Convert.ToDouble(num1.Text);
            i = Convert.ToDouble(num2.Text);
            double ans = x * i;
            Ans.Text = "Ans is: " + ans;
        }

        private void Divide_Click(object sender, RoutedEventArgs e)
        {
            double x = 0, i = 0;
            x = Convert.ToDouble(num1.Text);
            i = Convert.ToDouble(num2.Text);
            double ans = 1.0 * x / i;
            Ans.Text = "Ans is: " + ans;
        }

        private void Cleare_Click(object sender, RoutedEventArgs e)
        {
            num1.Text = ("");
            num2.Text = ("");
            Ans.Text = "Ans";
        }
    }
}
