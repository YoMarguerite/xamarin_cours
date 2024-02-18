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
	public partial class NbComponent : ContentView
	{
		public NbComponent ()
		{
			InitializeComponent ();

            //Binding sur le compteur des choix
            this.BindingContext = GetCompteur();
		}
	}
}