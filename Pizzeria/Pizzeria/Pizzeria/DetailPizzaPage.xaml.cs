using Pizzeria.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Pizzeria
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailPizzaPage : ContentPage
    {
        public Pizza PizzaDisplayed { get; set; }

        public DetailPizzaPage(Pizza pizza)
        {
            InitializeComponent();

            PizzaDisplayed = pizza;

            this.BindingContext = PizzaDisplayed;
        }
    }
}