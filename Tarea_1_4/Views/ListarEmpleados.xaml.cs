﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea_1_4.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Tarea_1_4;

namespace Tarea_1_4.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListarEmpleados : ContentPage
    {
        public ListarEmpleados()
        {
            InitializeComponent();
        }

        private async void toolmenu_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();

            listapersonas.ItemsSource = await App.BaseDatos.obtenerListaEmple();
        }

        private async void liestapersonas_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var persona = (Empleados)e.Item;
            VerImagen page = new VerImagen();
            page.BindingContext = persona;
            await Navigation.PushAsync(page);

        }
    }
}