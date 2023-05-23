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
        double SpdUnit, SizeUnit;
        

        public MainWindow()
        {
            InitializeComponent();
        }

        private void LBSpeed_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int speedIndex = LBSpeed.SelectedIndex;
            int speedUIndex = LBSpeedUnit.SelectedIndex;
            double SpdMulti = 0;

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
                        SpdUnit = SpdMulti;
                        break;
                    }
                case 1:
                    {
                        SpdUnit = SpdMulti * 8;
                        break;
                    }
                default:
                    {
                        SpdUnit = 0;
                        break;
                    }
            }

            kira();
        }

        private void LBSize_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int sizeIndex = LBSize.SelectedIndex;
            int sizeUIndex = LBSizeUnit.SelectedIndex;
            double SizeMulti = 0;
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
                        SizeUnit = SizeMulti ;
                        break;
                    }
                case 1:
                    {
                        SizeUnit = SizeMulti * 8;
                        break;
                    }
                default:
                    {
                        SizeUnit = 0;
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

        private void RunCalc (object sender, TextChangedEventArgs e)
        { 
            kira();   
        }

        private void NumbOnly (object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9][.]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        void kira()
        {
            if (TBoxSpeed.Text != "" && TBoxSize.Text != "" && SpdUnit != 0 && SizeUnit != 0)
            {
                double calc = (float.Parse(TBoxSize.Text) * SizeUnit) / (float.Parse(TBoxSpeed.Text) * SpdUnit);
                if(!Double.IsNaN(calc) && !Double.IsInfinity(calc) && calc!=0)
                {
                    string[] Result = TimeSpan.FromSeconds(calc).ToString(@"dd\:hh\:mm\:ss\:ffff").Split(':');
                    //TBoxDeb.Text = TimeSpan.FromSeconds(calc).ToString(@"dd\:hh\:mm\:ss\:ffff") + "  " + calc.ToString() + SpdUnit;
                    TBxDay.Text = Result[0];
                    TBxHr.Text = Result[1];
                    TBxMin.Text = Result[2];
                    TBxSec.Text = Result[3];
                    TBxmSec.Text = Result[4];
                    TBoxDeb.Text = DateTime.Now.AddSeconds(calc).ToString();
                }
                else
                {
                    TBxDay.Clear();
                    TBxHr.Clear();
                    TBxMin.Clear();
                    TBxSec.Clear();
                    TBxmSec.Clear();
                }
                
            }
            else
            {
                //TBoxDeb.Clear();
                TBxDay.Clear();
                TBxHr.Clear();
                TBxMin.Clear();
                TBxSec.Clear();
                TBxmSec.Clear();
            }            
        }
    }
}
