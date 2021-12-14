using mylib.Database;
using mylib.Model;
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
    /// Interaction logic for Window6.xaml
    /// </summary>
    public partial class Window6 : Window
    {
        public Window6()
        {
            InitializeComponent();
            //retrieveMembers();
        }

        private void register_click(object sender, RoutedEventArgs e)
        {

            //registerUser();
            Window1 toLogin = new Window1();
            toLogin.Show();
            this.Hide();

        }

        public void registerUser()
        {
            MemberContext context = new MemberContext();
            Member member1 = new Member()
            {
                fullName = full_name.Text,
                address = address.Text,
                telephone = telephone_no.Text,
                dob = dob.DisplayDate,
                email = e_mail.Text
            };

            context.members.Add(member1);
            context.SaveChanges();
        }

        public void retrieveMembers()
        {

            MemberContext context = new MemberContext();
            var memberlist = context.members.ToList();
            //test
            Console.WriteLine(memberlist);

        }
    }
}
