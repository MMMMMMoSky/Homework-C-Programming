using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Product_WPF
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {

        private int A, B;
        private bool flagA, flagB;

        public MainWindow()
        {
            InitializeComponent();
            A = 0;
            B = 0;
            flagA = true;
            flagB = true;
        }

        private void LHS_Changed(object sender, TextChangedEventArgs e)
        {
            try
            {
                A = Convert.ToInt32(LHS.Text);
                flagA = true;
            }
            catch (System.FormatException)
            {
                flagA = false;
            }
        }
        private void RHS_Changed(object sender, TextChangedEventArgs e)
        {
            try
            {
                B = Convert.ToInt32(RHS.Text);
                flagB = true;
            }
            catch (System.FormatException)
            {
                B = 0;
                flagB = false;
            }
        }

        private void RES_Click(object sender, RoutedEventArgs e)
        {
            if (flagA && flagB)
            {
                RES.Content = Convert.ToString(A * B);
            }
            else
            {
                RES.Content = "Invalid";
            }
        }
    }
}
