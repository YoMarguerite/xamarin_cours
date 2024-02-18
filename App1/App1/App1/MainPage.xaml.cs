using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            var tap = new TapGestureRecognizer();
            tap.Tapped += async (object sender, EventArgs e) =>
            {
                // Code qui sera exécuté lorsque l'événement sera déclenché
                this.ImgParam.Opacity = 0.5;
                await this.Navigation.PushAsync(new Configuration());
                this.ImgParam.Opacity = 1;
            };

            // On ajoute l'événement à l'image
            this.ImgParam.GestureRecognizers.Add(tap);
        }

        //private void Parameter_Tapped(View arg1, object arg2)
        //{
        //    this.Navigation.PushAsync(new Configuration());
        //}
    }
}
