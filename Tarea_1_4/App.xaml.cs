﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.IO;
using Tarea_1_4.Controllers;
using Tarea_1_4.Views;

namespace Tarea_1_4
{
    public partial class App : Application
    {
        static EmpleadosDB basedatos;

        public static EmpleadosDB BaseDatos
        {
            get
            {
                if (basedatos == null)
                {
                    basedatos = new EmpleadosDB(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "EmpleadosDB.db3"));
                }
                return basedatos;
            }
        }
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new ListarEmpleados());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
