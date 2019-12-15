using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseConnection.Database;
using Oracle.ManagedDataAccess.Client;
using System.Collections.ObjectModel;
using DTO.Tridy;
using System.IO;

namespace DatabaseConnection.Tabulky
{
    public class HattrickTable
    {
        // tahle trida se uklada do CSV


        public List<Hattrick> Select()
        {
            if (File.Exists("Hattrick.csv"))
            {
                using (var reader = new StreamReader("hattrick.csv"))
                {
                    Collection<Hattrick> data = new Collection<Hattrick>();
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var values = line.Split(',');
                        var hattrick = new Hattrick
                        {
                            HattrickId = Convert.ToInt32(values[0]),
                            Hrac = new Hrac
                            {
                                HracId = Int32.Parse(values[1])
                            },
                            Datum = DateTime.FromBinary(long.Parse(values[2]))
                        };
                        data.Add(hattrick);
                    }

                    return data.OrderBy(x => x.HattrickId).ToList();
                }
            }

            else
            {
                Collection<Hattrick> data = new Collection<Hattrick>();
                return data.ToList();
            }
        }

        public void Insert(int hrac, DateTime datum)
        {
            var csv = new StringBuilder();

            var newLine = string.Format("{0},{1},{2}{3}", LastIndex(), hrac.ToString(), datum.ToBinary().ToString(), Environment.NewLine);
            csv.Append(newLine);


            File.AppendAllText("hattrick.csv", csv.ToString());
        }

        private int LastIndex()
        {
            if (File.Exists("Hattrick.csv"))
            {
                using (var reader = new StreamReader("hattrick.csv"))
                {
                    int i = 0;
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        i++;
                    }
                    return i;
                }
            }
            else
            {
                return 0;
            }

        }
    }
}
