using RealmDb.Models;
using RealmDb.Views;
using Realms;
using System;
using Xamarin.Forms;

namespace RealmDb
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

		protected override void OnAppearing()
		{
			base.OnAppearing();
			var realmDb = Realm.GetInstance();
			var listaFuncionarios = realmDb.All<Funcionario>();
			lvFuncionarios.ItemsSource = listaFuncionarios;
		}

		private void lvFuncionarios_ItemSelected(object sender, SelectedItemChangedEventArgs e)
		{
			if (e.SelectedItem != null)
			{
				var funcionarioSelecionado = (Funcionario)e.SelectedItem;
				//Navigation.PushModalAsync(new ExibeFuncPage(funcionarioSelecionado));
			}
		}

		private async void Button_Clicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new NovoFuncPage());
		}
	}
}
