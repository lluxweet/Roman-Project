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

namespace RomanProject.Pages
{
    public partial class HomePage : Page
    {
        public HomePage()
        {
            InitializeComponent();
            AppFrame.frame = frame;
        }

        private void btnEmployees_Click(object sender, RoutedEventArgs e)
        {
            frame.Navigate(new EmployeesPage());
        }

        private void btnClients_Click(object sender, RoutedEventArgs e)
        {
            frame.Navigate(new ClientsPage());
        }

        private void btnOrders_Click(object sender, RoutedEventArgs e)
        {
            frame.Navigate(new OrdersPage());
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AuthorizationPage());
        }        
    }
}
