using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseAppManager.Model
{
    using DAL.Encje;
    using DAL.Repozytoria;
    using System.Collections.ObjectModel;
    using System.Windows;

    class Model
    {
        public ObservableCollection<Towar> Towary { get; set; } = new ObservableCollection<Towar>();
        public ObservableCollection<Magazyn> Magazyny { get; set; } = new ObservableCollection<Magazyn>();
        
        public Model()
        {
            var towary = RepozytoriumTowar.GetTowary();
            foreach (var t in towary)
            {
                Towary.Add(t);
            }
            var magazyny = RepozytoriumMagazyn.GetMagazyny();
            foreach (var m in magazyny)
            {
                Magazyny.Add(m);
            }
        }
        
        public ObservableCollection<Towar> GetTowarMagazynu(sbyte? id_magazynu)
        {
            ObservableCollection<Towar> towary = new ObservableCollection<Towar>();
            foreach (var t in Towary)
            {
                if (id_magazynu == t.IdMagazynu)
                {
                    towary.Add(t);
                }
            }
            return towary;
        }
    }
}
