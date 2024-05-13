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
    public partial class PageA : ContentPage
    {
        public PageA()
        {
            InitializeComponent();
        }

        private void EventoMenu(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        public async void EventoA(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}