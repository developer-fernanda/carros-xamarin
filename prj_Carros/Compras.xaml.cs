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
    public partial class Compras : ContentPage
    {
        mUsuario _usuario;

        public Compras(mVeiculos _veiculos)
        {
            InitializeComponent();
            this.BindingContext = _veiculos;
        }

        private async void Comprar_Clicked(object sender, EventArgs e)
        {
            //if (_usuario == null)
            //    return;

            if (string.IsNullOrEmpty(strNome.Text) || 
                string.IsNullOrEmpty(strFone.Text) ||
                string.IsNullOrEmpty(strEmail.Text))
            {
                await DisplayAlert(
                "Atenção",
                 "Por favor digite seus dados para continuar!",
                "Voltar");
                return;
            } else
            {
                _usuario = new mUsuario();
                _usuario.nome = "Parabéns, " + strNome.Text + "!";
                _usuario.telefone = strFone.Text;
                _usuario.email = strEmail.Text;

                await this.Navigation.PushModalAsync(new Finalizado(_usuario));
            }
        }
    }
}