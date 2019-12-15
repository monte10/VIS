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
    public class ZapasyTable
    {
        private readonly string select = "SELECT zapas_id, datum, tymy_tym_id, tymy_tym_id2, rozhodci_rozhodci_id, goly_domaci, goly_hoste, komentar FROM zapasy";
        private readonly string insert = "INSERT INTO zapasy (datum, tymy_tym_id, tymy_tym_id2, rozhodci_rozhodci_id, komentar)" +
                                "VALUES (:Datum, :TymDomaci, :TymHoste, :Rozhodci, :Komentar)";
        private readonly string update = "UPDATE zapasy SET goly_domaci = :GolyDomaci, goly_hoste = :GolyHoste WHERE zapas_id = :ID";
        private readonly string selectMax = "SELECT MAX(zapas_id) FROM zapasy";

        private Databaze db;

        public ZapasyTable()
        {
            db = new Databaze();
        }

        public int Insert(Zapas z)
        {
            using (db.GetConnection())
            {
                db.Connect();
                OracleCommand command = db.CreateCommand(insert);
                command.Parameters.AddWithValue(":Datum", z.Datum);
                command.Parameters.AddWithValue(":TymDomaci", z.Domaci.TymId);
                command.Parameters.AddWithValue(":TymHoste", z.Hoste.TymId);
                command.Parameters.AddWithValue(":Rozhodci", z.Rozhodci.RozhodciId);
                command.Parameters.AddWithValue(":Komentar", z.Komentar);
                int ret = db.ExecuteNonQuery(command);
                return ret;
            }
        }

        public int Update(int id, int domaci, int hoste)
        {
            using (db.GetConnection())
            {
                db.Connect();
                OracleCommand command = db.CreateCommand(update);
                command.Parameters.AddWithValue(":ID", id);
                command.Parameters.AddWithValue(":GolyDomaci", domaci);
                command.Parameters.AddWithValue(":GolyHoste", hoste);

                /*
                Console.WriteLine(id + " " + domaci + " " + hoste);

                for(int i =0; i<command.Parameters.Count; i++)
                {
                    Console.WriteLine(command.Parameters[i].Value.ToString());
                }
                */
                int ret = db.ExecuteNonQuery(command);
                return ret;
            }
        }

        /*
        public int UlozZapas(int cislo = -1)
        {
            using (db.GetConnection())
            {
                int Id;
                if (cislo == -1)
                {
                    Id = this.PosledniZapas();
                }
                else
                {
                    Id = cislo;
                }

                db.Connect();
                OracleCommand command = db.CreateCommand("AKTUALIZUJZAPAS");
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("p_zapas_id", OracleDbType.Int32).Value = Id;

                var ret = command.ExecuteNonQuery();

                db.Connect();
                command = db.CreateCommand("AKTUALIZUJVYLOUCENI");
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("p_zapas_id", OracleDbType.Int32).Value = Id;

                ret = command.ExecuteNonQuery();

                db.Connect();
                command = db.CreateCommand("AKTUALIZACEHATTRICK");
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("p_zapas_id", OracleDbType.Int32).Value = Id;

                ret = command.ExecuteNonQuery();

                db.Connect();
                command = db.CreateCommand("AKTUALIZACETYMU");
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("p_zapas_id", OracleDbType.Int32).Value = Id;

                ret = command.ExecuteNonQuery();

                return ret;
            }
        }
        */

        public int PosledniZapas()
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

        public List<Zapas> Select()
        {
            using (db.GetConnection())
            {
                db.Connect();
                OracleCommand command = db.CreateCommand(select);

                Collection<Zapas> data;

                using (var reader = command.ExecuteReader())
                {
                    data = Read(reader);
                }

                var sorted = data.OrderBy(x => x.ZapasId).ToList();
                return sorted;
            }
        }

        public static Collection<Zapas> Read(OracleDataReader reader)
        {
            var data = new Collection<Zapas>();

            while (reader.Read())
            {
                int i = -1;
                var zapas = new Zapas
                {
                    ZapasId = reader.GetInt32(++i),
                    Datum = reader.GetDateTime(++i),
                    Domaci = new Tym
                    {
                        TymId = reader.GetInt32(++i)
                    },
                    Hoste = new Tym
                    {
                        TymId = reader.GetInt32(++i)
                    },
                    Rozhodci = new Rozhodci
                    {
                        RozhodciId = reader.GetInt32(++i)
                    },
                    GolyDomaci = reader.GetInt32(++i),
                    GolyHoste = reader.GetInt32(++i)
                };

                if (!reader.IsDBNull(++i))
                {
                    zapas.Komentar = reader.GetString(i);
                }
                else
                {
                    zapas.Komentar = null;
                }
                data.Add(zapas);
            }
            return data;
        }
    }
}
