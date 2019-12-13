using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseConnection.Database;
using Oracle.ManagedDataAccess.Client;
using System.Data;
using System.Collections.ObjectModel;
using DTO.Tridy;

namespace DatabaseConnection.Tabulky
{
    class HraciTable
    {
        private readonly string select = "SELECT hrac_id, jmeno, prijmeni, cislo_dresu, pozice, rok_narozeni, tymy_tym_id, trestne_minuty FROM hraci";
        private readonly string insert = "INSERT INTO hraci (jmeno, prijmeni, cislo_dresu, pozice, rok_narozeni, tymy_tym_id)" +
                                "VALUES (:Jmeno, :Prijmeni, :Cislo, :Pozice, :Rok, :Tym)";
        private readonly string update = "UPDATE hraci SET testne_minuty = :Minuty WHERE hrac_id = :ID";
        private readonly string delete = "UPDATE hraci SET jmeno = 'Deleted' WHERE hrac_id = :ID";

        private Databaze db;

        public HraciTable()
        {
            db = new Databaze();
        }


        public int Insert(Hrac h)
        {
            using (db.GetConnection())
            {
                db.Connect();
                OracleCommand command = db.CreateCommand(insert);
                command.Parameters.AddWithValue(":Jmeno", h.Jmeno);
                command.Parameters.AddWithValue(":Prijmeni", h.Prijmeni);
                command.Parameters.AddWithValue(":Cislo", h.CisloDresu);
                command.Parameters.AddWithValue(":Pozice", h.Pozice);
                command.Parameters.AddWithValue(":Rok", h.RokNarozeni);
                command.Parameters.AddWithValue(":Tym", h.Tym.TymId);
                int ret = db.ExecuteNonQuery(command);
                return ret;
            }
        }

        public int Delete(int id)
        {
            using (db.GetConnection())
            {
                db.Connect();
                OracleCommand command = db.CreateCommand(delete);
                command.Parameters.AddWithValue(":ID", id);
                int ret = db.ExecuteNonQuery(command);
                return ret;
            }
        }

        public int Update(int id, int minuty)
        {
            using (db.GetConnection())
            {
                db.Connect();
                OracleCommand command = db.CreateCommand(update);
                command.Parameters.AddWithValue(":ID", id);
                command.Parameters.AddWithValue(":Minuty", minuty);
                int ret = db.ExecuteNonQuery(command);
                return ret;
            }
        }

        public List<Hrac> SelectTrestne()
        {
            using (db.GetConnection())
            {
                db.Connect();
                OracleCommand command = db.CreateCommand(select);

                Collection<Hrac> data;

                using (var reader = command.ExecuteReader())
                {
                    data = Read(reader);
                }

                var sorted = data.OrderByDescending(x => x.TrestneMinuty).ToList();
                return sorted;
            }
        }

        public List<Hrac> Select()
        {
            using (db.GetConnection())
            {
                db.Connect();
                OracleCommand command = db.CreateCommand(select);

                Collection<Hrac> data;

                using (var reader = command.ExecuteReader())
                {
                    data = Read(reader);
                }

                var sorted = data.OrderBy(x => x.HracId).ToList();
                return sorted;
            }
        }

        public static Collection<Hrac> Read(OracleDataReader reader)
        {
            var data = new Collection<Hrac>();

            while (reader.Read())
            {
                int i = -1;
                var h = new Hrac
                {
                    HracId = reader.GetInt32(++i),
                    Jmeno = reader.GetString(++i),
                    Prijmeni = reader.GetString(++i),
                    CisloDresu = reader.GetInt32(++i),
                    Pozice = reader.GetString(++i),
                    RokNarozeni = reader.GetInt32(i)
                };

                h.Tym = new Tym
                {
                    TymId = reader.GetInt32(++i)
                };
                h.TrestneMinuty = reader.GetInt32(++i);

                if (h.Jmeno != "Deleted")
                {
                    data.Add(h);
                }
            }
            return data;
        }
    }
}
