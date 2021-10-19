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
    public partial class TabbedPage1 : TabbedPage
    {
        public TabbedPage1()
        {
            InitializeComponent();
        }

        private void BackToPage1_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        private void BackToPage2_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        private void BackToPage3_Clicked_2(object sender, EventArgs e)
        {
            Navigation.PopAsync();

        }
    }
}