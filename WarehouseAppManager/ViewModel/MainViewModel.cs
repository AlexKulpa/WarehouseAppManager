using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseAppManager.ViewModel
{
    using BaseClass;
    using System.Collections.ObjectModel;
    using System.Windows.Input;
    using WarehouseAppManager.DAL.Encje;
    using WarehouseAppManager.Model;
    using WarehouseAppManager.View;

    class MainViewModel:BaseViewModel
    {
        private Model model = new Model();

        #region TOWARY
        private string nazwa_towaru, ilosc, jednostka, regal;
        private int indeksZaznaczonejOsoby = -1;
        private ObservableCollection<Towar> towary = null;
        public Towar BiezacyTowar { get; set; }
        public ObservableCollection<Towar> Towary {
            get { return towary; }
            set
            {
                towary = value;
                OnPropertyChanged(nameof(Towary));
            }
        }
        public string NazwaTowaru
        {
            get { return nazwa_towaru; }
            set
            {
                nazwa_towaru = value;
                OnPropertyChanged(nameof(NazwaTowaru));
            }
        }
        public string Ilosc
        {
            get { return ilosc; }
            set
            {
                ilosc = value;
                OnPropertyChanged(nameof(Ilosc));
            }
        }

        public string Jednostka
        {
            get { return jednostka; }
            set
            {
                jednostka = value;
                OnPropertyChanged(nameof(Jednostka));
            }
        }
        public string Regal
        {
            get { return regal; }
            set
            {
                regal = value;
                OnPropertyChanged(nameof(Regal));
            }
        }
        public int IndeksZaznaczonejOsoby
        {
            get { return indeksZaznaczonejOsoby; }
            set
            {
                indeksZaznaczonejOsoby = value;
                OnPropertyChanged(nameof(IndeksZaznaczonejOsoby));
            }
        }
        #endregion

        #region MAGAZYNY
        public ObservableCollection<Magazyn> Magazyny { get; set; }
        public Magazyn BiezacyMagazyn { get; set; }
        private string nazwa_magazynu;
        public string NazwaMagazynu
        {
            get { return nazwa_magazynu; }
            set
            {
                nazwa_magazynu = value;
                OnPropertyChanged(nameof(NazwaMagazynu));
            }
        }
        #endregion

        public AddingViewModel AddingVM { get; set; }
        public MainViewModel()
        {
            Towary = model.Towary;
            Magazyny = model.Magazyny;
            AddingVM = new AddingViewModel(model);
        }

        #region POLECENIA

        private ICommand zaladujTowar = null;
        public ICommand ZaladujTowar
        {
            get
            {
                if (zaladujTowar == null)
                {
                    zaladujTowar = new RelayCommand(
                        arg => {
                            if (BiezacyMagazyn != null)
                                Towary = model.GetTowarMagazynu(BiezacyMagazyn.Id);
                        },
                        arg => true
                        );
                }
                return zaladujTowar;
            }
        }

        private ICommand otworzOknoDodawania = null;
        public ICommand OtworzOknoDodawania
        {
            get
            {
                otworzOknoDodawania = new RelayCommand(
                    arg =>
                    {
                        AddWindow ekranDodawania = new AddWindow();
                        ekranDodawania.Show();
                        ekranDodawania.Owner = arg as MainWindow;
                    },
                    arg => true
                    );
                return otworzOknoDodawania;
            }
        }

        #endregion
    }
}
