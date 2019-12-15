using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseConnection.Database;
using Oracle.ManagedDataAccess.Client;
using DTO.Tridy;

namespace DatabaseConnection.Tabulky
{
    public class GolyTable
    {
        private readonly string select = "SELECT gol_id, hraci_hrac_id, zapasy_zapas_id FROM goly";
        private readonly string insert = "INSERT INTO goly (hraci_hrac_id, zapasy_zapas_id)" +
                                "VALUES (:Hrac, :Zapas)";
        private readonly string selectMax = "SELECT MAX(gol_id) FROM goly";

        private Databaze db;

        public GolyTable()
        {
            db = new Databaze();
        }


        public int Insert(Gol g)
        {
            using (db.GetConnection())
            {
                db.Connect();
                OracleCommand command = db.CreateCommand(insert);
                command.Parameters.AddWithValue(":Hrac", g.Hrac.HracId);

                var zap = new ZapasyTable();
                int maximum = zap.PosledniZapas();
                command.Parameters.AddWithValue(":Zapas", maximum);

                //command.Parameters.AddWithValue(":Zapas", g.Zapas.ZapasId);

                int ret = db.ExecuteNonQuery(command);
                return ret;
            }
        }

        public int PosledniGol()
        {
            db.Connect();
            OracleCommand command = db.CreateCommand(selectMax);
            int Id;

            using (var reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    Id = reader.GetInt32(0);
                }
                else
                {
                    Id = 0;
                }
            }
            return Id;
        }

        public List<Gol> Select()
        {
            using (db.GetConnection())
            {
                db.Connect();
                OracleCommand command = db.CreateCommand(select);

                Collection<Gol> data;

                using (var reader = command.ExecuteReader())
                {
                    data = Read(reader);
                }

                var sorted = data.OrderBy(x => x.GolId).ToList();
                return sorted;
            }
        }

        public static Collection<Gol> Read(OracleDataReader reader)
        {
            var data = new Collection<Gol>();

            while (reader.Read())
            {
                int i = -1;
                var goly = new Gol
                {
                    GolId = reader.GetInt32(++i),
                    Hrac = new Hrac
                    {
                        HracId = reader.GetInt32(++i)
                    },
                    Zapas = new Zapas
                    {
                        ZapasId = reader.GetInt32(++i)
                    }
                };
                data.Add(goly);
            }
            return data;
        }
    }
}
