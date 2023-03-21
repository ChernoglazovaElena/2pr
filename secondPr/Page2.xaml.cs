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
    /// Логика взаимодействия для Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        clothesTableAdapter clothes = new clothesTableAdapter();
        public Page2()
        {
            InitializeComponent();
            MyGrid.ItemsSource = clothes.GetData();
        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            int id = clothes.GetData().Count - 1;
            clothes.InsertQuery(NUU.Text);
            MyGrid.ItemsSource = clothes.GetData();
        }
    }
}
