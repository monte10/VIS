using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseConnection.Database;
using Oracle.ManagedDataAccess.Client;
using System.Collections.ObjectModel;
using DTO.Tridy;

namespace DatabaseConnection.Tabulky
{
    class RozhodciTable
    {
        private readonly string select = "SELECT rozhodci_id, jmeno, prijmeni, rok_narozeni FROM rozhodci";
        private readonly string insert = "INSERT INTO rozhodci (jmeno, prijmeni, rok_narozeni)" +
                                "VALUES (:Jmeno, :Prijmeni, :Rok)";

        private Databaze db;

        public RozhodciTable()
        {
            db = new Databaze();
        }

        public int Insert(Rozhodci r)
        {
            using (db.GetConnection())
            {
                db.Connect();
                OracleCommand command = db.CreateCommand(insert);
                command.Parameters.AddWithValue(":Jmeno", r.Jmeno);
                command.Parameters.AddWithValue(":Prijmeni", r.Prijmeni);
                command.Parameters.AddWithValue(":Rok", r.RokNarozeni);
                int ret = db.ExecuteNonQuery(command);
                return ret;
            }
        }

        public List<Rozhodci> Select()
        {
            using (db.GetConnection())
            {
                db.Connect();
                OracleCommand command = db.CreateCommand(select);

                Collection<Rozhodci> data;

                using (var reader = command.ExecuteReader())
                {
                    data = Read(reader);
                }

                var sorted = data.OrderBy(x => x.RozhodciId).ToList();
                return sorted;
            }
        }

        public static Collection<Rozhodci> Read(OracleDataReader reader)
        {
            var data = new Collection<Rozhodci>();

            while (reader.Read())
            {
                int i = -1;
                var rozhodci = new Rozhodci
                {
                    RozhodciId = reader.GetInt32(++i),
                    Jmeno = reader.GetString(++i),
                    Prijmeni = reader.GetString(++i),
                    RokNarozeni = reader.GetInt32(i)
                };

                data.Add(rozhodci);           
            }
            return data;
        }
    }
}
