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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для Vibor.xaml
    /// </summary>
    public partial class Vibor : Page
    {
        public Vibor()
        {
            InitializeComponent();
        }

        private void btn_User_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new UserReg());
        }

        private void btn_Designer_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Autorisation());
        }

        private void btn_Zakup_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Autorisation());
        }

        private void btn_Master_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Autorisation());
        }

        private void btn_Director_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Autorisation());
        }

        private void btn_AdminUp_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Autorisation());
        }

        private void btn_AdminDown_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Autorisation());
        }
    }
}
