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

namespace PractikaOleshki
{
    /// <summary>
    /// Логика взаимодействия для Login.xaml
    /// </summary>
    public partial class Login : Page
    {
        private ConnectionWithBase connection { get; set; }
        public Login(ConnectionWithBase conn)
        {
            InitializeComponent();
            connection = conn;
        }

        private void Log_In(object sender, RoutedEventArgs e)
        {
            if(login.Text.Length <= 0 || pass.Text.Length <= 0) { return; }
            foreach (var i in connection.Users)
            {
                if (login.Text == i.Login && pass.Text == i.Password)
                {
                    NavigationService.Navigate(new PageWithProduct());
                }
            }
        }
    }
}
