using RealmDb.Models;
using Realms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RealmDb.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class NovoFuncPage : ContentPage
	{
		public NovoFuncPage()
		{
			InitializeComponent();
		}

		private void Button_Clicked(object sender, EventArgs e)
		{
			var realmDb = Realm.GetInstance();
			var funcId = realmDb.All<Funcionario>().Count() + 1;
			var funcionario = new Funcionario
			{
				Id = funcId,
				Nome = txtNome.Text,
				Cargo = txtCargo.Text,
				Qualificacao = txtQualificacao.Text
			};

			realmDb.Write(() => {
				funcionario = realmDb.Add(funcionario);
			});

			Navigation.PopAsync();
		}
	}


}
