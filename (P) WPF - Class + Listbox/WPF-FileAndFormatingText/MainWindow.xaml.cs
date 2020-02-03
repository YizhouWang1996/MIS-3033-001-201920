using System;
using System.Collections.Generic;
using System.IO;
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

namespace WPF_FileAndFormatingText
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
            FlowDocument fd = new FlowDocument();
            Paragraph p = new Paragraph();
            Run text = new Run();



            var book = File.ReadAllText("Pride and Prejudice by Jane Austen.txt");
            text.Text = book;
            text.Foreground = Brushes.DarkBlue;
            text.Background = Brushes.Yellow;
            text.FontWeight = FontWeights.Bold;

            p.Inlines.Add(text);
            fd.Blocks.Add(p);
            rtbPride.Document = fd; 
               
        }

        private void btnCSV_Click(object sender, RoutedEventArgs e)
        {

            string path = Environment.GetEnvironmentVariable("USERPROFILE") + @"\Downloads\SalesJan2009.csv";
            string courseFile = $@"{path}\Course.csv";
            
            

            //string path = @"C:\Users\wang2311\source\repos\MIS-3033-001-201920\(P) WPF - Class + Listbox\WPF-FileAndFormatingText\SalesJan2009.csv";
            var lines=File.ReadAllLines(path);

            for (int i = 0; i < lines.Length; i++)
            {
                var line = lines[i];
                var pieces = line.Split(',');

                lstCSV.Items.Add(pieces[4]+"\t"+pieces[5]);
            }

            
        }
    }
}
