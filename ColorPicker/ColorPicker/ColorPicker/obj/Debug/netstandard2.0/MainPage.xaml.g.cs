//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: global::Xamarin.Forms.Xaml.XamlResourceIdAttribute("ColorPicker.MainPage.xaml", "MainPage.xaml", typeof(global::ColorPicker.MainPage))]

namespace ColorPicker {
    
    
    [global::Xamarin.Forms.Xaml.XamlFilePathAttribute("MainPage.xaml")]
    public partial class MainPage : global::Xamarin.Forms.ContentPage {
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private global::Xamarin.Forms.BoxView colorPicker;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private global::Xamarin.Forms.Slider SliderRed;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private global::Xamarin.Forms.Slider SliderGreen;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private global::Xamarin.Forms.Slider SliderBlue;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private void InitializeComponent() {
            global::Xamarin.Forms.Xaml.Extensions.LoadFromXaml(this, typeof(MainPage));
            colorPicker = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.BoxView>(this, "colorPicker");
            SliderRed = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.Slider>(this, "SliderRed");
            SliderGreen = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.Slider>(this, "SliderGreen");
            SliderBlue = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.Slider>(this, "SliderBlue");
        }
    }
}
