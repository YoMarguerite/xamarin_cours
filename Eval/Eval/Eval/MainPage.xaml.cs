using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Eval
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        //Navigation vers la page des liste des choix
        private void ChoixCollab(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ListeChoixPage());
        }

        //Navigation vers la page d'ajout d'un collaborateur
        private void AddCollab(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AjoutPage());
        }
    }
}
