﻿using System;
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

namespace Wpf_formularze_3A
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //String wpis = bokTxt.Text;
            if(double.TryParse(bokTxt.Text, out double result) )
            {
                //MessageBox.Show(result.ToString());
                komunikat.Text =string.Empty;
                double pole = result * result;
                double obw = 4 * result;
                wynikPole.Text = "Pole "+pole.ToString();
                wynikObwod.Text = "Obwód "+obw.ToString();
            }
            else
            { 
                komunikat.Text ="Musisz wpisać liczbę"; 
                wynikObwod.Text = string.Empty;
                wynikPole.Text=string.Empty;
            }
        }

        private void bokTxt_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(int.TryParse(bokTxt.Text, out int result))
            {
                kwadrat.Width = result;
                kwadrat.Height = result;
            }
        }
    }
}