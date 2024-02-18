using App1.Singleton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppParams
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Params : ContentPage
	{
		public Params ()
		{
			InitializeComponent ();
		}

        public void CompteActif_OnChanged(object sender, ToggledEventArgs e)
        {
            var singleton = Data.GetInstance();
            singleton.CompteActif = e.Value;
        }

        public void Email_Completed(object sender, EventArgs e)
        {
            var singleton = Data.GetInstance();
            singleton.Email = email.Text;
        }

        public void Telephone_Completed(object sender, EventArgs e)
        {
            var singleton = Data.GetInstance();
            singleton.Telephone = telephone.Text;
        }

        public void Position_OnChanged(object sender, ToggledEventArgs e)
        {
            var singleton = Data.GetInstance();
            singleton.CompteActif = e.Value;
        }
    }
}