using System.Collections.Generic;
using System.Linq;
using DatabaseConnection.Database;
using System.Collections.ObjectModel;
using Oracle.ManagedDataAccess.Client;
using DTO.Tridy;

namespace DatabaseConnection.Tabulky
{
    class ByvaliHraciTable
    {
        private readonly string select = "SELECT hrac_id, jmeno, prijmeni, cislo_dresu, pozice, rok_narozeni FROM byvali_hraci bh";
        private readonly string insert = "INSERT INTO byvali_hraci (jmeno, prijmeni, cislo_dresu, pozice, rok_narozeni)" +
                                "VALUES (:Jmeno, :Prijmeni, :Cislo, :Pozice, :Rok)";

        private Databaze db;

        public ByvaliHraciTable()
        {
            db = new Databaze();
        }



        public int Insert(ByvalyHrac b)
        {
            using (db.GetConnection())
            {
                db.Connect();
                OracleCommand command = db.CreateCommand(insert);
                command.Parameters.AddWithValue(":Jmeno", b.Jmeno);
                command.Parameters.AddWithValue(":Prijmeni", b.Prijmeni);
                command.Parameters.AddWithValue(":Cislo", b.CisloDresu);
                command.Parameters.AddWithValue(":Pozice", b.Pozice);
                command.Parameters.AddWithValue(":Rok", b.RokNarozeni);
                int ret = db.ExecuteNonQuery(command);

                return ret;
            }
        }

        public List<ByvalyHrac> Select()
        {
            using (db.GetConnection())
            {
                db.Connect();
                OracleCommand command = db.CreateCommand(select);

                Collection<ByvalyHrac> data;

                using (var reader = command.ExecuteReader())
                {
                    data = Read(reader);
                }

                var sorted = data.OrderBy(x => x.HracId).ToList();
                return sorted;


            }
        }

        public static Collection<ByvalyHrac> Read(OracleDataReader reader)
        {
            var data = new Collection<ByvalyHrac>();

            while (reader.Read())
            {
                int i = -1;
                var bh = new ByvalyHrac
                {
                    HracId = reader.GetInt32(++i),
                    Jmeno = reader.GetString(++i),
                    Prijmeni = reader.GetString(++i),
                    CisloDresu = reader.GetInt32(++i),
                    Pozice = reader.GetString(++i),
                    RokNarozeni = reader.GetInt32(++i)
                };
                data.Add(bh);
            }
            return data;
        }
    }
}
