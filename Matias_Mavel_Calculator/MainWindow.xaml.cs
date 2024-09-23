using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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

namespace Matias_Mavel_Calculator
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        double first_no = 0;
        double second_no =0;
        char operation= ' ';
        double result = 0;

        private void BTN_1_Click(object sender, RoutedEventArgs e)
        {
            Display("1");
        }

        private void BTN_2_Click(object sender, RoutedEventArgs e)
        {
            Display("2");
        }

        private void BTN_3_Click(object sender, RoutedEventArgs e)
        {
            Display("3");
        }

        private void BTN_4_Click(object sender, RoutedEventArgs e)
        {
            Display("4");
        }

        private void BTN_5_Click(object sender, RoutedEventArgs e)
        {
            Display("5");
        }

        private void BTN_6_Click(object sender, RoutedEventArgs e)
        {
            Display("6");
        }

        private void BTN_7_Click(object sender, RoutedEventArgs e)
        {
            Display("7");
        }

        private void BTN_8_Click(object sender, RoutedEventArgs e)
        {
            Display("8");
        }

        private void BTN_9_Click(object sender, RoutedEventArgs e)
        {
            Display("9");
        }

        private void BTN_0_Click(object sender, RoutedEventArgs e)
        {
            Display("0");
        }

        private void BTN_Plus_Click(object sender, RoutedEventArgs e)
        {
            first_no = double.Parse(TB_Display.Text);
            TB_Display.Text = "0";
            operation = '+';
        }

        private void BTN_minus_Click(object sender, RoutedEventArgs e)
        {
            first_no = double.Parse(TB_Display.Text);
            TB_Display.Text = "0";
            operation = '-';
        }

        private void BTN_MUL_Click(object sender, RoutedEventArgs e)
        {
            first_no = double.Parse(TB_Display.Text);
            TB_Display.Text = "0";
            operation = '*';
        }

        private void BTN_divide_Click(object sender, RoutedEventArgs e)
        {
            first_no = double.Parse(TB_Display.Text);
            TB_Display.Text = "0";
            operation = '/';
        }

        private void BTN_egal_Click(object sender, RoutedEventArgs e)
        {
            second_no = double.Parse( TB_Display.Text);
            switch (operation)
            {
                case '+':

                     result = first_no + second_no;
                    TB_Display.Text = result.ToString();
                    break;

                case '-':
                   
                    result = first_no - second_no;
                    TB_Display.Text = result.ToString();
                    break;

                case '*':
                  
                    result = first_no * second_no;
                    TB_Display.Text = result.ToString();
                    break;

                case '/':

                     result = (double)first_no / second_no;
                    TB_Display.Text = result.ToString();
                    break;

                case 'a':

                    result = Math.Round(Math.Sqrt(first_no), 2);
                    TB_Display.Text = result.ToString();

                    break;

                case 'b':

                    result = Math.Round(Math.Log10(first_no), 2);
                    TB_Display.Text = result.ToString();
                    result = first_no;

                    break;

                case 'c':
                    
                    result = Math.Round(Math.Log(first_no), 2);
                    TB_Display.Text = result.ToString();
                    break;

                case 'd':

                    result = Math.Round(Math.Cos(first_no), 2);
                    TB_Display.Text= result.ToString();
                    break;

                case 'e':

                    result = Math.Round(Math.Tan(first_no), 2);
                    TB_Display.Text = result.ToString();

                    break;

                case 'f':

                    result = Math.Round(Math.Sin(first_no), 2);
                    TB_Display.Text = result.ToString();
                    break;        
                
                case 'g':

                    result =  Math.Pow(first_no, second_no);
                    TB_Display.Text = result.ToString();
                    break;

                case '%':

                    result = first_no % second_no;
                    TB_Display.Text = result.ToString();
                    break;
            }
        }
        private void BTN_CLR_Click(object sender, RoutedEventArgs e)
        {
            TB_Display.Text = "0";
            Display("0");
        }


        private void BTN_sqrt_Click(object sender, RoutedEventArgs e)
        {
            first_no = double.Parse(TB_Display.Text);
            TB_Display.Text = "0";
            operation = 'a';
        }


        private void BTN_LOG_Click(object sender, RoutedEventArgs e)
        {
            first_no = double.Parse(TB_Display.Text);
            TB_Display.Text = "0";
            operation = 'b';

        }

        private void BTN_LN_Click(object sender, RoutedEventArgs e)
        {
            first_no = double.Parse(TB_Display.Text);
            TB_Display.Text = "0";
            operation = 'c';
        }

        private void BTN_cos_Click(object sender, RoutedEventArgs e)
        {
            first_no = double.Parse(TB_Display.Text);
            TB_Display.Text = "0";
            operation = 'd';
        }

        private void BTN_tan_Click(object sender, RoutedEventArgs e)
        {
            first_no = double.Parse(TB_Display.Text);
            TB_Display.Text = "0";
            operation = 'e';
        }


        private void BTN_SIN_Click(object sender, RoutedEventArgs e)
        {
            first_no = double.Parse(TB_Display.Text);
            TB_Display.Text = "0";
            operation= 'f';
        }


        private void BTN_pui_Click(object sender, RoutedEventArgs e)
        {
            first_no = double.Parse(TB_Display.Text);
            TB_Display.Text = "0";
            operation = 'g';
        }

        private void BTN_mod_Click(object sender, RoutedEventArgs e)
        {
            first_no = double.Parse(TB_Display.Text) ;
            TB_Display.Text = "0";
            operation = '%';
        }

        private void BTN_pi_Click(object sender, RoutedEventArgs e)
        {
            result = (Math.PI);
            TB_Display.Text = result.ToString();
        }


        public void Display(string num)
        {
            if (TB_Display.Text == "0")
            {
                TB_Display.Text = num;
            }
            else
            {
                TB_Display.Text = TB_Display.Text + num;
            }
        }

    }
}