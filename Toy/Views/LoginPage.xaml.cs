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
using Toy.Models;

namespace Toy.Views
{

    public partial class LoginPage : Page
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void Login_Button_Click(object sender, RoutedEventArgs e)
        {
            User currentUser = AppData.db.User.FirstOrDefault(u => u.Login == TxbLogin.Text);

            if (currentUser == null)
            {
                MessageBox.Show("user cant found");
                return;
            }

            if (currentUser.Login == TxbLogin.Text && currentUser.Password == TxbPassword.Password)
            {
                MessageBox.Show("досуп получн");
                AppData.CurrentAccessLevel = currentUser.Role.AccessLevel;
                NavigationService.Navigate(new Shop());
            } 
            else
            {
                MessageBox.Show("Incorrect password");
            }
        }
    }
}
