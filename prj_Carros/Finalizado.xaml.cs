using prj_Carros.Modals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace prj_Carros
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Finalizado : ContentPage
    {
        public Finalizado(mUsuario _usuario)
        {
            InitializeComponent();
            this.BindingContext = _usuario;
        }

        private async void btnVoltar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new MainPage());
        }
    }
}