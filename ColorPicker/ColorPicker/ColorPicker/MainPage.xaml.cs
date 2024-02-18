using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ColorPicker
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            this.SliderRed.Value = 50;
            this.SliderGreen.Value = 100;
            this.SliderBlue.Value = 150;

        }

        private void SliderRed_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            RefreshBoxView(e.NewValue, this.SliderGreen.Value, this.SliderBlue.Value);
        }

        private void SliderGreen_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            RefreshBoxView(this.SliderRed.Value, e.NewValue, this.SliderBlue.Value);
        }

        private void SliderBlue_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            RefreshBoxView(this.SliderRed.Value, this.SliderGreen.Value, e.NewValue);
        }

        private void RefreshBoxView(double red, double green, double blue)
        {
            int r = Convert.ToInt32(red);
            int g = Convert.ToInt32(green);
            int b = Convert.ToInt32(blue);

            this.colorPicker.Color = Color.FromRgb(r, g, b);
        }
    }
}
