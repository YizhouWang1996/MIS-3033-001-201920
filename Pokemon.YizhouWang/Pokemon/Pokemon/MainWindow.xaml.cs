using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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


namespace Pokemon
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            string path = "https://pokeapi.co/api/v2/pokemon?offset=0limit=1000";

            PokemonAPI PokemonAPI;
            using (var client=new HttpClient())
            {
                string json = client.GetStringAsync(SelectedPokemon.url).Result;

                PokemonAPI = JsonConvert.DeserializeObject<AllPokemonResult>(json);
            }

            foreach (var pokemon in PokemonAPI.results)
            {
                LstCharacters.Items.Add(pokemon);
            }
        }

       
        
        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectPokemon = (AllPokemonResult)LstCharacters.SelectedItem;

            //imgCharacter.Source = new BitmapImage(new Uri("https://rickandmortyapi.com/api/character/avatar/1.jpeg"));
            imgCharacter.Source = new BitmapImage(new Uri(selectPokemon.url));

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
