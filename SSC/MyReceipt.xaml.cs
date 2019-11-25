using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SSC
{
    /// <summary>
    /// Логика взаимодействия для MyReceipt.xaml
    /// </summary>
    public partial class MyReceipt : Page
    {
        public MainWindow Window;
        public List<Receipt> Receipt { get; set; }
        public MyReceipt(MainWindow Window)
        {
            InitializeComponent();
            this.Window = Window;
            Receipt = new List<Receipt>();
            var result = Window.context.Receipts.SingleOrDefault(x => x.AbonentId == Window.Abonent.Id);
            Receipt.Add(result);
            label_name.Content += Window.Abonent.FullName;
            int totalDebt = result.ElectricityDebt + result.GasDebt + result.InternetDebt + result.WaterDebt;
            label_totalDebt.Content += totalDebt.ToString();
            DataContext = this;
        }

        private void lstw_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
