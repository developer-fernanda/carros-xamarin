using System;
using prj_Carros.Modals;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace prj_Carros
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class listaVeiculos : ContentPage
    {
        //mVeiculos _veiculos;
        public listaVeiculos(mUsuario usuario)
        {
            InitializeComponent();
            this.BindingContext = new mListaVeiculos();
        }

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            var _container = BindingContext as mListaVeiculos;
            veiculosListView.BeginRefresh();
            if (string.IsNullOrWhiteSpace(e.NewTextValue))
                veiculosListView.ItemsSource = _container.lvVeiculos;
            else
                veiculosListView.ItemsSource = 
                    _container.lvVeiculos.Where(i => i.nomeCarro.Contains(e.NewTextValue));
            veiculosListView.EndRefresh();
        }

        private void adicionar_Clicked(object sender, EventArgs e)
        {
            var _container = BindingContext as mListaVeiculos;
        }
        private async void veiculosListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var _veiculos = e.SelectedItem as mVeiculos;

            if (_veiculos == null)
                return;

            await this.Navigation.PushModalAsync(new Compras(_veiculos));
        }
        private async void comprar_Clicked(object sender, EventArgs e)
        {

            var btn = sender as Button;
            var _veiculos = btn.CommandParameter as mVeiculos;

            await DisplayAlert("Informações",
                "Km: " + _veiculos.km + "\n" +
                "Cambio: " + _veiculos.cambio + "\n" +
                "Carroceria: " + _veiculos.carroceria + "\n" +
                "Combustivel: " + _veiculos.combustivel + "\n" +
                "Final da placa: " + _veiculos.finalDePlaca + "\n" +
                "Cor: " + _veiculos.cor + "\n" +
                "Aceita troca: " + _veiculos.aceitaTroca,
                "Voltar");
        }

        private void Pesquisar_Clicked(object sender, EventArgs e)
        {    
        }

        private void listaCarros_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

        }


    }
}