using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Resource.Models
{
    public class DataAccessLayer
    {
        public List<string> ColumbNames { get; set; } = new List<string>();

        public List<string> ColumbValues { get; set; } = new List<string>();

        public List<Tuple<int, List<string>, List<string>>> Row { get; set; } = new List<Tuple<int, List<string>, List<string>>>();

        private int rowNumber = 0;

        public async Task<List<Tuple<int, List<string>, List<string>>>> GetDB_DataAsync(string searchQuery)
        {
            Row.Clear();

            Program.ReadJSONConfig();
            string connString = Program.Settings.ConnectionStrings["ResourceContext"];

            using (SqlConnection connection = new SqlConnection(connString))
            {
                connection.Open();

                SqlCommand querry = new SqlCommand(searchQuery, connection);

                using (SqlDataReader reader = querry.ExecuteReader())
                {
                    while (await reader.ReadAsync())
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

                        Row.Add(new Tuple<int, List<string>, List<string>>(rowNumber, ColumbValues, ColumbNames));

                        rowNumber++;
                    }
                    reader.Close();
                }

                connection.Close();
            }
            return Row;
        }

        public List<Tuple<int, List<string>, List<string>>> GetDB_Data(string searchQuery)
        {
            Row.Clear();
            Program.ReadJSONConfig();
            string connString = Program.Settings.ConnectionStrings["ResourceContext"];

            using (SqlConnection connection = new SqlConnection(connString))
            {
                connection.Open();

                SqlCommand querry = new SqlCommand(searchQuery, connection);

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

                        Row.Add(new Tuple<int, List<string>, List<string>>(rowNumber, ColumbValues, ColumbNames));

                        rowNumber++;
                    }
                    reader.Close();
                }

                connection.Close();
            }
            return Row;
        }

        public void UpdateDbEntry(string updateQuery)
        {
            Program.ReadJSONConfig();
            string connString = Program.Settings.ConnectionStrings["ResourceContext"];

            using (SqlConnection connection = new SqlConnection(connString))
            {
                connection.Open();

                SqlCommand querry = new SqlCommand(updateQuery, connection);

                using (sqlda reader = querry.ExecuteReader())
                {
                    while (reader.Read())
                    {
                    }
                    reader.Close();
                }

                connection.Close();
            }
        }

        public List<Tuple<int, List<string>, List<string>>> GetCustomersHavingMachines(string searchQuery)
        {
            Row.Clear();
            Program.ReadJSONConfig();
            string connString = Program.Settings.ConnectionStrings["ResourceContext"];

            using (SqlConnection connection = new SqlConnection(connString))
            {
                connection.Open();

                SqlCommand querry = new SqlCommand(searchQuery, connection);

                using (SqlDataReader reader = querry.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ColumbNames = new List<string>();

                        ColumbValues = new List<string>();

                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            foreach (string value in ColumbValues)
                            {
                                if (value == reader.GetValue(i).ToString() && value != "" && (reader.GetName(i) == "CUSTOMER_OBJ_NO" || reader.GetName(i) == "OBJ_NO"))
                                {
                                    continue;
                                }
                            }
                            if (ColumbNames.Count != reader.FieldCount)
                            {
                                ColumbNames.Add(reader.GetName(i));
                            }

                            ColumbValues.Add(reader.GetValue(i).ToString());
                        }

                        Row.Add(new Tuple<int, List<string>, List<string>>(rowNumber, ColumbValues, ColumbNames));

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