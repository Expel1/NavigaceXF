using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NavigaceXF
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void NewPage_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TabbedPage1());
        }

        private void BackToMainPage_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}