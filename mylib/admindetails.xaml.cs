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
using System.Windows.Shapes;

namespace mylib
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window11 toLogin = new Window11();
            toLogin.Show();
           // this.Hide();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Window4 toLogin = new Window4();
            toLogin.Show();
            // this.Hide();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Window3 toLogin = new Window3();
            toLogin.Show();
            //this.Hide();
        }
    }
}
