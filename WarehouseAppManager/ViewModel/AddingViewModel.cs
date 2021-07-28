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
    class AddingViewModel : BaseViewModel
    {
        private Model model = null;
        private ObservableCollection<Towar> towary = null;
        private ObservableCollection<Magazyn> magazyny = null;
        public AddingViewModel() { }
        public AddingViewModel(Model model)
        {
            this.model = model;
        }

        #region polecenia

        private ICommand dodajTowarDoBazy = null;
        public ICommand DodajTowarDoBazy
        {
            get
            {
                dodajTowarDoBazy = new RelayCommand(
                    arg => {
                        AddWindow window = arg as AddWindow;
                        window.Close();
                    },
                    arg => true
                    );
                return dodajTowarDoBazy;
            }
        }

        #endregion
    }
}
