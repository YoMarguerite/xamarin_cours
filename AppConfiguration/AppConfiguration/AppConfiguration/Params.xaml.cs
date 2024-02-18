using AppConfiguration.Model;
using AppConfiguration.Singleton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppConfiguration
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Params : ContentPage
	{
        public Params ()
		{
			InitializeComponent();

            var singleton = Datas.GetInstance();
            
            this.compteActif.IsEnabled = singleton.CompteActif;
            this.email.Text = singleton.Email;
            this.telephone.Text = singleton.Telephone;
            this.position.IsEnabled = singleton.AutoriseLocation;
        }

        private void Position_OnChanged(object sender, ToggledEventArgs e)
        {
            var singleton = Datas.GetInstance();
            singleton.AutoriseLocation = e.Value;
        }

        private void Telephone_Completed(object sender, EventArgs e)
        {
            var singleton = Datas.GetInstance();
            singleton.Telephone = telephone.Text;
        }

        private void Email_Completed(object sender, EventArgs e)
        {
            var singleton = Datas.GetInstance();
            singleton.Email = email.Text;
        }

        private void CompteActif_OnChanged(object sender, ToggledEventArgs e)
        {
            var singleton = Datas.GetInstance();
            singleton.CompteActif = e.Value;
        }
    }
}