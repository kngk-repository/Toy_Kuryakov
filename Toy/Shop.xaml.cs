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
using Toy.Views;

namespace Toy
{
    /// Логика взаимодействия для Shop.xaml
    public partial class Shop : Window
    {
        public Shop()
        {
            InitializeComponent();
            ShopFrame.Navigate(new Shop());
        }
    }
}
