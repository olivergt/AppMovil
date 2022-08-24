using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppMovil
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BienvenidosPage : ContentPage
    {
        public BienvenidosPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Título", "Hola Mundo!", "Cancelar");
        }
    }
}