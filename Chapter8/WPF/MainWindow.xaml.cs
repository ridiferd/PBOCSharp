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

namespace WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            CustomerGrid.DataContext = GetCustomers();
        }

        private List<Customer> GetCustomers()
        {
            var result = new List<Customer>();

            result.Add(new Customer()
            {
                Firstname = "Alexander",
                LastName = "Frostbite",
                Address = "Sweden Street"
            });

            result.Add(new Customer()
            {
                Firstname = "Juliano",
                LastName = "Maradondo",
                Address = "Venezuela Street"
            });

            result.Add(new Customer()
            {
                Firstname = "Dominique",
                LastName = "Elizabeth",
                Address = "New Jersey Steet"
            });

            return result;
        }
    }
}
