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
	public partial class Configuration : TabbedPage
    {
		public Configuration ()
		{
			InitializeComponent ();
		}
	}
}