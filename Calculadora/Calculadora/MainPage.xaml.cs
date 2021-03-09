using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Calculadora
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

       
        private void dizerNomeCompleto(object sender, EventArgs e)
        {
            var text1 = nome.Text;
            var text2 = sobrenome.Text;

            DisplayAlert("Nome Completo!", text1 + " " + text2, "OK");

        }
    }
}
