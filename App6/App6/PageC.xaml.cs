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
    public partial class PageC : ContentPage
    {
        public PageC()
        {
            InitializeComponent();
        }
        private void EventoMenu(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
        private async void EventoC(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
        private async void EventoD(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
        private async void EventoA(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}