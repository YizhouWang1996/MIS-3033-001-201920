//Yizhou Wang
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

namespace _P__WPF___Class___Listbox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            EntryForm ef = new EntryForm();
            ef.Address = txtAddress.Text;
            ef.Name = txtName.Text;
            ef.ZipCode =Convert.ToInt32(txtZipcode.Text);
 
            
            
            ListBox.Items.Add(ef.ToString());
        }
    }
}
