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

namespace Download_Time_Calc
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }



        private void ButtCalc_Click(object sender, RoutedEventArgs e)
        {
            SPRes.Visibility = Visibility.Visible;
            
        }

        private void TBoxSpeed_TextChanged(object sender, TextChangedEventArgs e)
        {
            TBoxDeb.Text = TBoxSpeed.Text;
        }



        private void LBISpeedT_Selected(object sender, RoutedEventArgs e)
        {
            TBoxDeb.Text = "tera selected";
        }

        private void ButtClear_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
