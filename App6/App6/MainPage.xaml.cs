using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App6
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void EventoA(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PageA());
        }
        private void EventoB(object sender, EventArgs e)
        {

            Navigation.PushAsync(new PageB());
        }
        private void EventoC(object sender, EventArgs e)
        {

            Navigation.PushAsync(new PageC());
        }
        private void EventoD(object sender, EventArgs e)
        {

            Navigation.PushAsync(new PageD());
        }
    }
}
