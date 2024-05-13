using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App6
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageB : ContentPage
    {
        public PageB()
        {
            InitializeComponent();
        }

        private void EventoMenu(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
        private async void EventoA(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
        private async void EventoB(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}