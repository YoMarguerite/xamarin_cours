using Eval.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using static Eval.Data.Data;

namespace Eval
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AjoutPage : ContentPage
    {
		public AjoutPage ()
		{
			InitializeComponent ();

            service.ListElement = new string[] { "Comptabilité", "Informatique", "Technique" };
            choix.ListElement = new string[] { "Galaxy S10", "Iphone XS" };
		}

        //ajout des collaborateurs
        public void NewCollab(object sender, EventArgs e)
        {
            Console.WriteLine(nom.Text+" "+ prenom.Text + " " + choix.selected + " " + service.selected);

            AjoutCollabs(nom.Text, prenom.Text, choix.selected, service.selected);
        }
	}
}