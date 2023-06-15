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
    /// Логика взаимодействия для Cients.xaml
    /// </summary>
    public partial class Cients : Page
    {
        public Cients()
        {
            InitializeComponent();
        }
        private void Btn_Back_Cick(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
