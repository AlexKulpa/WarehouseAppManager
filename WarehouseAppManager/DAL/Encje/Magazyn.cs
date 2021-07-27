using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace WarehouseAppManager.DAL.Encje
{
    class Magazyn
    {
        //id, nazwa, id_lokalizacji
        public sbyte? Id { get; set; }
        public string Nazwa { get; set; }
        public sbyte? IdLokalizacji { get; set; }

        public Magazyn(MySqlDataReader reader)
        {
            Id = sbyte.Parse(reader["id"].ToString());
            Nazwa = reader["nazwa"].ToString();
            IdLokalizacji = sbyte.Parse(reader["id_lokalizacji"].ToString());
        }
    }
}
