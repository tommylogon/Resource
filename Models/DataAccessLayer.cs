using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Resource.Models
{
    public class DataAccessLayer
    {
        public string Table { get; set; }

        public string Columbs { get; set; }

        public List<string> ColumbNames { get; set; } = new List<string>();

        public List<string> ColumbValues { get; set; } = new List<string>();

        public List<Tuple<int, List<string>>> Row { get; set; } = new List<Tuple<int, List<string>>>();

        private int rowNumber = 0;

        public List<Tuple<int, List<string>>> GetDB_Data(string table, string columbs)
        {
            Program.ReadJSONConfig();
            string connString = Program.Settings.ConnectionStrings["ResourceContext"];

            using (SqlConnection connection = new SqlConnection("Server= ITD-K01-Z400\\EVATIC; Database=Evatic; User ID = sa; Password = 1414; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False"))
            {
                connection.Open();

                SqlCommand querry = new SqlCommand("SELECT " + Columbs + " FROM " + Table, connection);

                using (SqlDataReader reader = querry.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ColumbNames = new List<string>();

                        ColumbValues = new List<string>();

                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            if (ColumbNames.Count != reader.FieldCount)
                            {
                                ColumbNames.Add(reader.GetName(i));
                            }

                            ColumbValues.Add(reader.GetValue(i).ToString());
                        }

                        Row.Add(new Tuple<int, List<string>>(rowNumber, ColumbValues));

                        rowNumber++;
                    }
                    reader.Close();
                }

                connection.Close();
            }
            return Row;
        }
    }
}