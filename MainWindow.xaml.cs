using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Text.RegularExpressions;
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
        double SpdMulti = 0;
        String SpdUnit= "";
        double SizeMulti = 0;
        String SizeUnit = "";
        double calc = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void LBSpeed_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int speedIndex = LBSpeed.SelectedIndex;
            int speedUIndex = LBSpeedUnit.SelectedIndex;

            switch (speedIndex)
            {
                case 0:
                    {
                        SpdMulti = Math.Pow(10,12);
                        break;                        
                    }
                case 1:
                    {
                        SpdMulti = Math.Pow(10, 9);
                        break;
                    }
                case 2:
                    {
                        SpdMulti = Math.Pow(10, 6);
                        break;
                    }
                case 3:
                    {
                        SpdMulti = Math.Pow(10, 3);
                        break;
                    }
            }

            switch (speedUIndex)
            {
                case 0:
                    {
                        SpdUnit = " Bit";
                        break;
                    }
                case 1:
                    {
                        SpdUnit = " Byte";
                        break;
                    }
                
            }
            kira();


        }

        private void LBSize_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int sizeIndex = LBSize.SelectedIndex;
            int sizeUIndex = LBSizeUnit.SelectedIndex;

            switch (sizeIndex)
            {
                case 0:
                    {
                        SizeMulti = Math.Pow(10, 12);
                        break;
                    }
                case 1:
                    {
                        SizeMulti = Math.Pow(10, 9);
                        break;
                    }
                case 2:
                    {
                        SizeMulti = Math.Pow(10, 6);
                        break;
                    }
                case 3:
                    {
                        SizeMulti = Math.Pow(10, 3);
                        break;
                    }
            }

            switch (sizeUIndex)
            {
                case 0:
                    {
                        SizeUnit = " Bit";
                        break;
                    }
                case 1:
                    {
                        SizeUnit = " Byte";
                        break;
                    }

            }
            kira();
        }

        private void ButtClear_Click(object sender, RoutedEventArgs e)
        {

            TBoxSpeed.Clear();
            TBoxSize.Clear();
            TBoxDeb.Clear();
            LBSpeed.UnselectAll();
            LBSpeedUnit.UnselectAll();
            LBSize.UnselectAll();
            LBSizeUnit.UnselectAll();
            TBxDay.Clear();
            TBxHr.Clear();
            TBxMin.Clear();
            TBxSec.Clear();
        }

        void runboi()
        {

        }
        private void RunCalc (object sender, TextChangedEventArgs e)
        { 
            kira();   
        }

        private void NumbOnly (object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        void kira()
        {
            if (TBoxSpeed.Text != "" && TBoxSize.Text != "" && SpdMulti != 0 && SizeMulti != 0)
            {
                calc = (double.Parse(TBoxSize.Text) * SizeMulti) / (double.Parse(TBoxSpeed.Text) * SpdMulti);
                TBoxDeb.Text = calc.ToString();
            }
            else
            {
                TBoxDeb.Text = "";
            }
            
        }
    }

}
