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
using DAL2.DAL;

namespace WPF_with_entityframework
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DataofTheBase data;
        public MainWindow()
        {
            InitializeComponent();

            data = new DataofTheBase();
            data.Biler.Load();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            foreach (var bil in data.Biler)
            {
                ListBox.Items.Add(bil);
            }
        }
    }
}
