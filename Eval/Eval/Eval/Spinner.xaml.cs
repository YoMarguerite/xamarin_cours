using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;


//Classe Spinner

namespace Eval
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Spinner : ContentView
    {
        public Spinner()
        {
            InitializeComponent();
            selected = "oui !";
            listview.ItemsSource = ListElement;

        }

        //Item selected
        public string selected { get; set; }

        //Liste des éléments à afficher
        private string[] list_element;

        public string[] ListElement
        {
            get { return list_element; }
            set { list_element = value;
                listview.ItemsSource = value;
                selected = value.First();
                listview.SelectedItem = value.First();
            }
        }


        private void Button_Clicked(object sender, EventArgs e)
        {
            listview.IsVisible = !listview.IsVisible;
        }

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            selected = listview.SelectedItem as string;
        }
    }
}