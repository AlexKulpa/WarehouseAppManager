using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace WarehouseAppManager.DAL.Encje
{
    class Towar
    {
        //id, ilosc, jednostka, nazwa, regał, id_magazynu
        public sbyte? Id { get; set; }
        public int Ilosc { get; set; }
        public string Jednostka { get; set; }
        public string Nazwa { get; set; }
        public string Regal { get; set; }
        public sbyte? IdMagazynu { get; set; }

        public Towar (MySqlDataReader reader)
        {
            Id = sbyte.Parse(reader["id"].ToString());
            Ilosc = int.Parse(reader["ilość"].ToString());
            Jednostka = reader["jednostka"].ToString();
            Nazwa = reader["nazwa"].ToString();
            Regal = reader["regał"].ToString();
            IdMagazynu = sbyte.Parse(reader["id_magazynu"].ToString());
        }
        public Towar (sbyte ilosc, string jednostka, string nazwa, string regal, sbyte idmagazynu)
        {
            Id = null;
            Ilosc = ilosc;
            Jednostka = jednostka;
            Nazwa = nazwa;
            Regal = regal;
            IdMagazynu = idmagazynu;
        }
        public Towar (Towar towar)
        {
            Id = towar.Id;
            Ilosc = towar.Ilosc;
            Jednostka = towar.Jednostka;
            Nazwa = towar.Nazwa;
            Regal = towar.Regal;
            IdMagazynu = towar.IdMagazynu;
        }

        public string ToInsert()
        {
            return $"('{Ilosc}', '{Jednostka}', {Nazwa}, '{Regal}', '{IdMagazynu}')";
        }
        public override bool Equals(object obj)
        {
            var towar = obj as Towar;
            if (towar is null) return false;
            if (Nazwa.ToLower() != towar.Nazwa.ToLower()) return false;
            if (Regal.ToLower() != towar.Regal.ToLower()) return false;
            if (IdMagazynu != towar.IdMagazynu) return false;
            return true;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
