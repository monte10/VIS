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
    public class TymyTable
    {
        private readonly string select = "SELECT tym_id, nazev, pocet_vyher, pocet_remiz, pocet_proher, treneri_trener_id FROM tymy";
        private readonly string update = "UPDATE tymy SET pocet_vyher = :Vyhry, pocet_remiz = :Remizy, pocet_proher = :Prohry WHERE tym_id = :ID";

        private Databaze db;

        public TymyTable()
        {
            db = new Databaze();
        }

        public int Update(Tym t)
        {
            using (db.GetConnection())
            {
                db.Connect();
                OracleCommand command = db.CreateCommand(update);
                command.Parameters.AddWithValue(":ID", t.TymId);
                command.Parameters.AddWithValue(":Vyhry", t.PocetVyher);
                command.Parameters.AddWithValue(":Remizy", t.PocetRemiz);
                command.Parameters.AddWithValue(":Prohry", t.PocetProher);
                int ret = db.ExecuteNonQuery(command);
                return ret;
            }
        }

        public List<Tym> Select()
        {
            using (db.GetConnection())
            {
                db.Connect();
                OracleCommand command = db.CreateCommand(select);

                Collection<Tym> data;

                using (var reader = command.ExecuteReader())
                {
                    data = Read(reader);
                }

                var sorted = data.OrderByDescending(x => x.PocetVyher).ThenBy(x => x.PocetRemiz).ToList();

                return sorted;


            }
        }

        public static Collection<Tym> Read(OracleDataReader reader)
        {
            var data = new Collection<Tym>();

            while (reader.Read())
            {
                int i = -1;
                var tym = new Tym
                {
                    TymId = reader.GetInt32(++i),
                    Nazev = reader.GetString(++i),
                    PocetVyher = reader.GetInt32(++i),
                    PocetRemiz = reader.GetInt32(++i),
                    PocetProher = reader.GetInt32(++i),
                    Trener = new Trener
                    {
                        TrenerId = reader.GetInt32(++i)
                    }
                };
                data.Add(tym);
            }
            return data;
        }
    }
}
