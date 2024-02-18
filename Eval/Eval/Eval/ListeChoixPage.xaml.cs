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
	public partial class ListeChoixPage : ContentPage
	{
		public ListeChoixPage ()
		{
			InitializeComponent ();

            //Binding sur la liste des collaborateurs
            listeCollabs.ItemsSource = GetCollaborateurs();
		}
	}
}