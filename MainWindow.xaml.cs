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

        private void LBSpeed_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int speed = LBSpeed.SelectedIndex;
            int speedU = LBSpeedUnit.SelectedIndex;
            String strout = "";
            TBoxDeb.Text = "";

            switch (speed)
            {
                case 0:
                    {
                        //TBoxDeb.Text = "Tera ";
                        strout = "Speed Tera ";
                        break;
                    }
                case 1:
                    {
                        //TBoxDeb.Text = "Giga ";
                        strout = "Speed Giga ";
                        break;
                    }
                case 2:
                    {
                        //TBoxDeb.Text = "Mega ";
                        strout = "Speed Mega ";
                        break;
                    }
                case 3:
                    {
                        //TBoxDeb.Text = "Kilo ";
                        strout = "Speed Kilo ";
                        break;
                    }
            }

            switch (speedU)
            {
                case 0:
                    {
                        strout = strout + "Bit";
                        break;
                    }
                case 1:
                    {
                        strout = strout + "Byte";
                        break;
                    }
                
            }
            TBoxDeb.Text = strout;


        }

        private void LBSize_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int size = LBSize.SelectedIndex;
            int sizeU = LBSizeUnit.SelectedIndex;
            String strout = "";
            TBoxDeb.Text = "";

            switch (size)
            {
                case 0:
                    {
                        //TBoxDeb.Text = "Tera ";
                        strout = "Size Tera ";
                        break;
                    }
                case 1:
                    {
                        //TBoxDeb.Text = "Giga ";
                        strout = "Size Giga ";
                        break;
                    }
                case 2:
                    {
                        //TBoxDeb.Text = "Mega ";
                        strout = "Size Mega ";
                        break;
                    }
                case 3:
                    {
                        //TBoxDeb.Text = "Kilo ";
                        strout = "Size Kilo ";
                        break;
                    }
            }

            switch (sizeU)
            {
                case 0:
                    {
                        strout = strout + "Bit ";
                        break;
                    }
                case 1:
                    {
                        strout = strout + "Byte ";
                        break;
                    }

            }
            TBoxDeb.Text = strout;


        }

        private void ButtClear_Click(object sender, RoutedEventArgs e)
        {

            TBoxSpeed.Text = "";
            TBoxSize.Text = "";
            TBoxDeb.Text = "";
            LBSpeed.UnselectAll();
            LBSpeedUnit.UnselectAll();
            LBSize.UnselectAll();
            LBSizeUnit.UnselectAll();
            TBxDay.Text = "";
            TBxHr.Text = "";
            TBxMin.Text = "";
            TBxSec.Text = "";
        }
    }
}
