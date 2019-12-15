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
    public class AsistenceTable
    {
        private readonly string select = "SELECT asistence_id, hraci_hrac_id, zapasy_zapas_id, goly_gol_id FROM asistence";
        private readonly string insert = "INSERT INTO asistence (hraci_hrac_id, zapasy_zapas_id, goly_gol_id)" +
                                "VALUES (:Hrac, :Zapas, :Gol)";

        private Databaze db;

        public AsistenceTable()
        {
            db = new Databaze();
        }

        public int Insert(Asistence a)
        {
            using (db.GetConnection())
            {
                db.Connect();
                OracleCommand command = db.CreateCommand(insert);
                command.Parameters.AddWithValue(":Hrac", a.Hrac.HracId);

                var zap = new ZapasyTable();
                int maximumZ = zap.PosledniZapas();
                command.Parameters.AddWithValue(":Zapas", maximumZ);
                //command.Parameters.AddWithValue(":Zapas", a.Zapas.ZapasId);

                var gol = new GolyTable();
                int maximumG = gol.PosledniGol();
                command.Parameters.AddWithValue(":Gol", maximumG);
                //command.Parameters.AddWithValue(":Gol", a.Gol.GolId);

                int ret = db.ExecuteNonQuery(command);
                return ret;
            }
        }
        
        public List<Asistence> Select()
        {
            using (db.GetConnection())
            {
                db.Connect();
                OracleCommand command = db.CreateCommand(select);

                Collection<Asistence> data;

                using (var reader = command.ExecuteReader())
                {
                    data = Read(reader);
                }
                var sorted = data.OrderBy(x => x.Zapas.ZapasId).ThenBy(x => x.AsistenceId).ToList();
                return sorted;


            }
        }

        public static Collection<Asistence> Read(OracleDataReader reader)
        {
            var data = new Collection<Asistence>();

            while (reader.Read())
            {
                int i = -1;
                var asistence = new Asistence
                {
                    AsistenceId = reader.GetInt32(++i),
                    Hrac = new Hrac
                    {
                        HracId = reader.GetInt32(++i)
                    },
                    Zapas = new Zapas
                    {
                        ZapasId = reader.GetInt32(++i)
                    },
                    Gol = new Gol
                    {
                        GolId = reader.GetInt32(++i)
                    }
                };
                data.Add(asistence);
            }
            return data;
        }

    }
}
