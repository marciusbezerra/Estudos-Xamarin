using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XFDataBiding
{
    public partial class MainPage : ContentPage
    {
        private DetailsViewModel model = new DetailsViewModel();

        public MainPage()
        {
            InitializeComponent();

            BindingContext = model;
            ListViewItems.ItemsSource = model.Caracteristicas;
        }

        private void ButtonAddClicked(object sender, EventArgs e)
        {
            model.Caracteristicas.Add(new Carateristica { Descricao = entryCaracDescricao.Text, Valor = entryCaracValor.Text });
            entryCaracDescricao.Text = "";
            entryCaracValor.Text = "";
        }

        private void ButtonChangeLastClicked(object sender, EventArgs e)
        {
            var lastItem = model.Caracteristicas.LastOrDefault();
            if (lastItem != null)
                lastItem.Valor = "Modificado!";
        }
    }

    internal class DetailsViewModel : INotifyPropertyChanged
    {
        private string _nome;
        private string _sobrenome;

        public DetailsViewModel()
        {
            Caracteristicas = new ObservableCollection<Carateristica>();
        }

        public string Nome
        {
            get => _nome; set
            {
                if (_nome != value)
                {
                    _nome = value;
                    NotifyPropChanged(nameof(Nome));
                }
            }
        }
        public string Sobrenome
        {
            get => _sobrenome; set
            {
                if (_sobrenome != value)
                {
                    _sobrenome = value;
                    NotifyPropChanged(nameof(Sobrenome));
                }
            }
        }

        public ObservableCollection<Carateristica> Caracteristicas { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void NotifyPropChanged(string propName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
    }

    public class Carateristica : INotifyPropertyChanged
    {
        private string _descricao;
        private string _valor;

        public string Descricao
        {
            get => _descricao; set
            {
                if (_descricao != value)
                {
                    _descricao = value;
                    NotifyPropChanged(nameof(Descricao));
                }
            }
        }
        public string Valor
        {
            get => _valor; set
            {
                if (_valor != value)
                {
                    _valor = value;
                    NotifyPropChanged(nameof(Valor));
                }
            }
        }

        public override string ToString()
        {
            return $"{Descricao} = {Valor}";
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void NotifyPropChanged(string propName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
    }
}
