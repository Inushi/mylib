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
    /// Interaction logic for Window7.xaml
    /// </summary>
    public partial class Window7 : Window
    {
        public Window7()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window8 toLogin = new Window8();
            toLogin.Show();
            //this.Hide();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Window9 toLogin = new Window9();
            toLogin.Show();
            //this.Hide();
        }
    }
}
