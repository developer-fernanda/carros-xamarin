using System;
using prj_Carros.Modals;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace prj_Carros
{
    public partial class MainPage : ContentPage
    {
        mUsuario _usuario;
        public MainPage()
        {
            InitializeComponent();
        }
        public async void BtnEntrar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new listaVeiculos(_usuario));
        }
    }
}
