using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseAppManager.DAL.Repozytoria
{
    using Encje;
    using MySql.Data.MySqlClient;

    class RepozytoriumTowar
    {
        private const string SELECT_TOWARY = "SELECT * FROM `towar`";
        private const string INSERT_TOWAR = "INSERT INTO `towar` (`ilość`, `jednostka`, `nazwa`, `regał`) VALUES ";

        public static List<Towar> GetTowary()
        {
            List<Towar> towary = new List<Towar>();
            using (var connection = DBConnection.Instance.Connection)
            {
                MySqlCommand command = new MySqlCommand(SELECT_TOWARY, connection);
                connection.Open();
                var reader = command.ExecuteReader();
                while (reader.Read()) towary.Add(new Towar(reader));
                connection.Close();
            }
            return towary;
        }

        public static void AddTowar(Towar towar)
        {
            using (var connection = DBConnection.Instance.Connection)
            {
                MySqlCommand command = new MySqlCommand($"{INSERT_TOWAR} {towar.ToInsert()}", connection);
                connection.Open();
                var id = command.ExecuteNonQuery();
                towar.Id = (sbyte)command.LastInsertedId;
                connection.Close();
            }
        }
    }
}
