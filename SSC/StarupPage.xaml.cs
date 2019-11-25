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
    /// Логика взаимодействия для StarupPage.xaml
    /// </summary>
    public partial class StarupPage : Page
    {
        public MainWindow Window;

        public StarupPage(MainWindow Window)
        {
            InitializeComponent();
            this.Window = Window;
        }

        private void GoButton_Click(object sender, RoutedEventArgs e)
        {
            var result = Window.context.Abonents.SingleOrDefault(x => x.IIN == textBox_IIN.Text);
            if (result != null)
            {
                Window.Abonent = result;
                Window.frame.Navigate(new MyReceipt(Window));
            }
            else
            {
                MessageBox.Show("Абонент не найден в базе данных");
            }
        }
    }
}
