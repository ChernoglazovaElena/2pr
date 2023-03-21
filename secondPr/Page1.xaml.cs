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
using secondPr.bdDataSetTableAdapters;

namespace secondPr
{
    /// <summary>
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        shoesTableAdapter shoes = new shoesTableAdapter();
        public Page1()
        {
            InitializeComponent();
            MyGrid.ItemsSource = shoes.GetData();
        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            int id = shoes.GetData().Count - 1;
            shoes.InsertQuery(id, Convert.ToInt32(NUU.Text));
            MyGrid.ItemsSource = shoes.GetData();
        }
    }
}
