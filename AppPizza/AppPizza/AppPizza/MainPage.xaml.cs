using AppPizza.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppPizza
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            ObservableCollection<Pizza>  Pizzas = new ObservableCollection<Pizza>
            {
                new Pizza("Mexicaine", false, "Piment", 10),
                new Pizza("Forestierre", true, "Champignon", 12),
                new Pizza("Kebab", false, "Chêvre", 9),
                new Pizza("Montagnarde", true, "Raclette", 11),
                new Pizza("Margarita", false, "Tomate", 8)
            };

            ListDisplay.ItemsSource = Pizzas;
        }
    }
}
