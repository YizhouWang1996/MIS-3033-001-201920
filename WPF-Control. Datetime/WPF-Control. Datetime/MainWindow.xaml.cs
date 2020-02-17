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

namespace WPF_Control.Datetime
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            txtBirthDate.Text = ""; //txtBirthDate.Text = string.Empty; (same)
            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {


            lstLetters.Items.Clear();
            string firstname, lastname, birthDate;
            firstname = txtFirstName.Text;
            lastname = txtLastName.Text;
            birthDate = txtBirthDate.Text;

            DateTime bDate = DateTime.Now; // sets it to current date and time at this exact moment of execution
            bDate = Convert.ToDateTime(birthDate);


            string fullName = firstname + "" + lastname;

            //for (int i = 0; i < fullName.Length; i++)
            //{
            //    char letter = fullName[i];
            //    lstLetters.Items.Add(letter);
            //}

            foreach (char letter in fullName)
            {
                lstLetters.Items.Add(letter);
            }
            string message = $"{fullName}, born on {bDate.DayOfWeek}, \n Thank you for submitting=)!";
            MessageBox.Show(message);
        }

        private void lstLetters_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
