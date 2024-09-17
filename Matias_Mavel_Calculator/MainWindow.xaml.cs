﻿using System;
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
        int first_no =0;
        int second_no =0;
        char operation= ' ';
        int result = 0;

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
            first_no = Int32.Parse(TB_Display.Text);
            TB_Display.Text = "0";
            operation = '+';
        }

        private void BTN_minus_Click(object sender, RoutedEventArgs e)
        {
            first_no = Int32.Parse(TB_Display.Text);
            TB_Display.Text = "0";
            operation = '-';
        }

        private void BTN_MUL_Click(object sender, RoutedEventArgs e)
        {
            first_no = Int32.Parse(TB_Display.Text);
            TB_Display.Text = "0";
            operation = '*';
        }

        private void BTN_divide_Click(object sender, RoutedEventArgs e)
        {
            first_no = Int32.Parse(TB_Display.Text);
            TB_Display.Text = "0";
            operation = '/';
        }

        private void BTN_egal_Click(object sender, RoutedEventArgs e)
        {
            second_no = int.Parse( TB_Display.Text);
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
                  
                    result = first_no / second_no;
                    TB_Display.Text = result.ToString();
                    break;
            }
        }
        private void BTN_CLR_Click(object sender, RoutedEventArgs e)
        {
            TB_Display.Text = "0";
            Display("0");
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
