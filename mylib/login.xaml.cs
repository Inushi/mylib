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
using System.Windows.Shapes;

namespace mylib
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void register_click(object sender, RoutedEventArgs e)
        {

            Window6 toRegister = new Window6();
            toRegister.Show();
            this.Hide();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
             
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Window2 toLogin = new Window2();
            toLogin.Show();
            this.Hide();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Window7 toLogin = new Window7();
            toLogin.Show();
            this.Hide();
        }
    }
}
