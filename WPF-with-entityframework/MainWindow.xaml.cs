using System;
using System.Collections.Generic;
using System.Data.Entity;
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
using BLL2;
using DTO2.models;

namespace WPF_with_entityframework
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            foreach (var bil in BLL.GetBiller())
            {
                ListBox.Items.Add(bil);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var id = txtID.Text;

            Bill bill = BLL.getBill(int.Parse(id));
            ListBox.Items.Clear();
            ListBox.Items.Add(bill);
        }
    }
}
