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

namespace Toy
{
    /// <summary>
    /// Логика взаимодействия для SPage.xaml
    /// </summary>
    public partial class SPage : Page
    {
        public SPage()
        {
            InitializeComponent();
        }
        private void Change_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Cients());
        }

        private void Add_btn_click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("TEST");
        }

        private void Exit_Btn_Cick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("TEST");
        }
    }
}
