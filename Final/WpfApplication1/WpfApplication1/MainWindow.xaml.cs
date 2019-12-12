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

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Hard hard;
        Curve curve;

        public MainWindow()
        {
            InitializeComponent();
            hard = new Hard("Mmkl");

            InitializeComponent();
            curve = new Curve("mkl");
        }


        private int i = 0;
        
        private void Hard_Button_Click(object sender, RoutedEventArgs e)
        {
            i++;

            txtBox1.Text = i.ToString();
            hard.YouWin();
            BCapture.IsEnabled = false;
            if (BCapture.IsEnabled == false)
            {
                CCapture.IsEnabled = false;
                DCapture.IsEnabled = false;
            }
        }

        private void Curve_Button_Click(object sender, RoutedEventArgs e)
        {

            i++;
            txtBox1.Text = i.ToString();

            curve.Tryagain();
            CCapture.IsEnabled = false;
            if (CCapture.IsEnabled == false)
            {
               DCapture.IsEnabled = true;
            }
        }

        private void Gentle_Button_Click(object sender, RoutedEventArgs e)
        {

            i++;
            txtBox1.Text = i.ToString();

            curve.Tryagain();
            DCapture.IsEnabled = false;

            if (DCapture.IsEnabled == false)
            {
                BCapture.IsEnabled = false;
                CCapture.IsEnabled = false;
                ECapture.IsEnabled = true;
            }
        }

        private void Spiral_Button_Click(object sender, RoutedEventArgs e)
        {
            i++;
            txtBox1.Text = i.ToString();

            curve.Tryagain();
            ECapture.IsEnabled = false;

            if (ECapture.IsEnabled == false)
            {
                BCapture.IsEnabled = true;
                CCapture.IsEnabled = false;
                DCapture.IsEnabled = true;
            }

        }



        private void Rocket_Button_Click(object sender, RoutedEventArgs e)
        {

            i++; i++; i++;
            txtBox1.Text = i.ToString();

            curve.Tryagain();
            FCapture.IsEnabled = true;

            if (FCapture.IsEnabled == true)
            {
                BCapture.IsEnabled = false;
                CCapture.IsEnabled = true;
                DCapture.IsEnabled = true;
                ECapture.IsEnabled = true;
            }

        }
    }
}
