using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppConfiguration
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            // On créé l'événement "appuyé sur l'image"
            var tgr = new TapGestureRecognizer();
            tgr.Tapped += async (object sender, EventArgs e) =>
            {
                // Code qui sera exécuté lorsque l'événement sera déclenché
                this.ImgParam.Opacity = 0.5;
                await this.Navigation.PushAsync(new Configuration());
                this.ImgParam.Opacity = 1;
            };

            // On ajoute l'événement à l'image
            this.ImgParam.GestureRecognizers.Add(tgr);
        }

        private void Parameter_Tapped(View arg1, object arg2)
        {
            this.Navigation.PushAsync(new Configuration());
        }

        private void ImageButton_Clicked(object sender, EventArgs e)
        {
            this.Navigation.PushAsync(new Configuration());
        }
    }
}
