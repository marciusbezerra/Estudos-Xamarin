using EF_Core_Sqlite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace EF_Core_Sqlite
{
	public partial class App : Application
	{
		public App (string databasePath)
		{
			InitializeComponent();

            var listaClientes = new List<Cliente>();

            using (var db = new AppDbContext(databasePath))
            {
                db.Database.EnsureCreated();

                db.Clientes.Add(new Cliente { Nome = "Marcius Carneiro Bezerra" });
                db.Clientes.Add(new Cliente { Nome = "Lia Carneiro Bezerra" });
                db.Clientes.Add(new Cliente { Nome = "Lívia Marielly Aragão Bezerra" });
                db.Clientes.Add(new Cliente { Nome = "Francisco Lucas Bezerra" });
                db.Clientes.Add(new Cliente { Nome = "Maria de Jesus Carneiro Bezerra" });

                db.SaveChanges();

                listaClientes = db.Clientes.ToList();
            }

            MainPage = new MainPage
            {
                Content = new ListView
                {
                    ItemsSource = listaClientes
                }
            };
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
