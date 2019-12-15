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
    public class TreneriTable
    {
        private readonly string select = "SELECT trener_id, jmeno, prijmeni, rok_narozeni FROM treneri";
        private readonly string insert = "INSERT INTO treneri (jmeno, prijmeni, rok_narozeni)" +
                                "VALUES (:Jmeno, :Prijmeni, :Rok)";

        private Databaze db;

        public TreneriTable()
        {
            db = new Databaze();
        }

        public int Insert(Trener t)
        {
            using (db.GetConnection())
            {
                db.Connect();
                OracleCommand command = db.CreateCommand(insert);
                command.Parameters.AddWithValue(":Jmeno", t.Jmeno);
                command.Parameters.AddWithValue(":Prijmeni", t.Prijmeni);
                command.Parameters.AddWithValue(":Rok", t.RokNarozeni);
                int ret = db.ExecuteNonQuery(command);
                return ret;
            }
        }

        public List<Trener> Select()
        {
            using (db.GetConnection())
            {
                db.Connect();
                OracleCommand command = db.CreateCommand(select);

                Collection<Trener> data;

                using (var reader = command.ExecuteReader())
                {
                    data = Read(reader);
                }

                var sorted = data.OrderBy(x => x.TrenerId).ToList();
                return sorted;


            }
        }

        public static Collection<Trener> Read(OracleDataReader reader)
        {
            var data = new Collection<Trener>();

            while (reader.Read())
            {
                int i = -1;
                var trener = new Trener
                {
                    TrenerId = reader.GetInt32(++i),
                    Jmeno = reader.GetString(++i),
                    Prijmeni = reader.GetString(++i),
                    RokNarozeni = reader.GetInt32(++i)
                };
                data.Add(trener);
            }
            return data;
        }
    }
}
