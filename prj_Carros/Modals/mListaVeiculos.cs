using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;

namespace prj_Carros.Modals
{
    public class mListaVeiculos
    {
        public ObservableCollection<mVeiculos> lvVeiculos { get; set; }

        public mListaVeiculos()
        {
            lvVeiculos = new ObservableCollection<mVeiculos>() 
            {
                new mVeiculos
                {
                    imagemCarro = "Mobi.png",
                    nomeCarro = "Fiat Mobi",
                    preco = "R$ 42.900,00",
                    anoModelo = "Ano/Mod: 2018/2018",
                    km = "75.342 Km",
                    cambio = "Manual",
                    carroceria = "Hatchback",
                    combustivel = "Gasolina e Álcool",
                    finalDePlaca = "7",
                    cor = "Prata",
                    aceitaTroca = "Sim"
                },
                new mVeiculos
                {
                    imagemCarro = "Jeep.png",
                    nomeCarro = "Jeep Renegade",
                    preco = "R$ 91.000,00",
                    anoModelo = "Ano/Mod: 2015/2016",
                    km = "100.700",
                    cambio = "Automático",
                    carroceria = "Ultilitário Esportivo",
                    combustivel = "Diesel",
                    finalDePlaca = "1",
                    cor = "Preto",
                    aceitaTroca = "Sim"
                },
                new mVeiculos
                {
                    imagemCarro = "Doblo.png",
                    nomeCarro = "Fiat Doblô",
                    preco = "R$ 54.900,00",
                    anoModelo = "Ano/Mod: 2015/2016",
                    km = "85.230",
                    cambio = "Manual",
                    carroceria = "Minivan",
                    combustivel = "Gasolina e álcool",
                    finalDePlaca = "0",
                    cor = "Cinza",
                    aceitaTroca = "Sim"
                },
                new mVeiculos
                {
                    imagemCarro = "ix35.png",
                    nomeCarro = "Hyundai Ix35",
                    preco = "R$ 57.900,00",
                    anoModelo = "Ano/Mod: 2014/2015",
                    km = "171",
                    cambio = "Automático",
                    carroceria = "Ultilitário esportivo",
                    combustivel = "Gasolina e álcool",
                    finalDePlaca = "2",
                    cor = "Prata",
                    aceitaTroca = "Sim"
                },
                new mVeiculos
                {
                    imagemCarro = "tucson.png",
                    nomeCarro = "Hyundai Tucson",
                    preco = "R$ 108.000,00",
                    anoModelo = "Ano/Mod: 2017/2018",
                    km = "69.641",
                    cambio = "Automático",
                    carroceria = "Ultilitário esportivo",
                    combustivel = "Gasolina",
                    finalDePlaca = "7",
                    cor = "Prata",
                    aceitaTroca = "Sim"
                },
            };
        }
    }
}
