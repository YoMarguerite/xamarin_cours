using Pizzeria.DAL;
using Pizzeria.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Pizzeria
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            listePizzas.ItemsSource = Datas.GetInstance().GetCartePizzas();
        }

        private async void ListePizzas_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            Pizza selectedPizza = this.listePizzas.SelectedItem as Pizza;
            await this.Navigation.PushAsync(new DetailPizzaPage(selectedPizza));
        }
    }
}
