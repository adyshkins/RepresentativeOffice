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
using RepresentativeOffice.AppData;
namespace RepresentativeOffice
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Product> products = new List<Product>();
        public MainWindow()
        {
            InitializeComponent();
        }

        //private List<Product> Search()
        //{
        //    products = EF.context.Product.ToList();

        //    products = products.Where(i => i.NameProduct.Contains(txtName.Text) || 
        //    i.Description.Contains(txtDesc.Text)).ToList();
        //    return products;

        //}

        private void tbEquipment_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("dfgdfg");
        }

        private void tbRepairRequests_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {

        }

        private void tbWarrantyInformation_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
