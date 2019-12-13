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
    class TrestyTable
    {
        private readonly string select = "SELECT trest_id, delka, duvod, hraci_hrac_id, zapasy_zapas_id FROM tresty";
        private readonly string insert = "INSERT INTO tresty (delka, duvod, hraci_hrac_id, zapasy_zapas_id)" +
                                "VALUES (:Delka, :Duvod, :Hrac, :Zapas)";


        private Databaze db;

        public TrestyTable()
        {
            db = new Databaze();
        }

        public int Insert(Trest t)
        {
            using (db.GetConnection())
            {
                db.Connect();
                OracleCommand command = db.CreateCommand(insert);
                command.Parameters.AddWithValue(":Delka", t.Delka);
                command.Parameters.AddWithValue(":Duvod", t.Duvod);
                command.Parameters.AddWithValue(":Hrac", t.Hrac.HracId);

                var zap = new ZapasyTable();
                int maximum = zap.PosledniZapas();
                command.Parameters.AddWithValue(":Zapas", maximum);

                //command.Parameters.AddWithValue(":Zapas", t.Zapas.ZapasId);

                int ret = db.ExecuteNonQuery(command);
                return ret;
            }
        }

        public List<Trest> Select()
        {
            using (db.GetConnection())
            {
                db.Connect();
                OracleCommand command = db.CreateCommand(select);

                Collection<Trest> data;

                using (var reader = command.ExecuteReader())
                {
                    data = Read(reader);
                }

                var sorted = data.OrderBy(x => x.Zapas.ZapasId).ThenBy(x => x.TrestId).ToList();
                return sorted;
            }
        }

        public static Collection<Trest> Read(OracleDataReader reader)
        {
            var data = new Collection<Trest>();

            while (reader.Read())
            {
                int i = -1;
                var trest = new Trest
                {
                    TrestId = reader.GetInt32(++i),
                    Delka = reader.GetInt32(++i),
                    Duvod = reader.GetString(++i),
                    Hrac = new Hrac
                    {
                        HracId = reader.GetInt32(++i)
                    },
                    Zapas = new Zapas
                    {
                        ZapasId = reader.GetInt32(++i)
                    }
                };
                data.Add(trest);

            }
            return data;
        }
    }
}
