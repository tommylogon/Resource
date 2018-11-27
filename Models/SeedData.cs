using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace Resource.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ResourceContext(
                serviceProvider.GetRequiredService<DbContextOptions<ResourceContext>>()))
            {
                if (context.Customer.Any())
                {
                    return;
                }
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder
                {
                    DataSource = @"ITD-K01-Z400\EVATIC",
                    UserID = "sa",
                    Password = "1414",
                    InitialCatalog = "Evatic"
                };

                List<string> prevCUID = new List<string>();

                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    connection.Open();
                    SqlCommand querry = new SqlCommand("SELECT  CUSTOMER.OBJ_NO, CUSTOMER.CUSTOMER_NAME, ADDRESS.ADDRESS_1, CONTACT.MOBILE_PHONE_NO, CUSTOMER.ORGANIZATION_NO, CUSTOMER.OBJ_DATE FROM ADDRESS INNER JOIN MACHINE ON ADDRESS.SOURCE_OBJ_NO = MACHINE.CUSTOMER_OBJ_NO INNER JOIN CUSTOMER on MACHINE.CUSTOMER_OBJ_NO = CUSTOMER.OBJ_NO INNER JOIN DOCUMENT on DOCUMENT.SOURCE_OBJ_NO = MACHINE.OBJ_NO INNER JOIN CONTACT on CUSTOMER.OBJ_NO = CONTACT.OBJ_NO group by CUSTOMER.OBJ_NO, CUSTOMER.CUSTOMER_NAME, ADDRESS.ADDRESS_1, CONTACT.MOBILE_PHONE_NO, CUSTOMER.ORGANIZATION_NO, CUSTOMER.OBJ_DATE ", connection);

                    using (SqlDataReader reader = querry.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Customer newCustomer = new Customer();
                            try
                            {
                                if (!prevCUID.Contains(reader.GetValue(0).ToString()))
                                {
                                    prevCUID.Add(reader.GetValue(0).ToString());

                                    newCustomer.CustomerID = reader.GetValue(0).ToString();
                                    newCustomer.CustomerName = reader.GetValue(1).ToString();
                                    newCustomer.Adress = reader.GetValue(2).ToString();
                                    newCustomer.Phone = reader.GetValue(3).ToString();
                                    newCustomer.OrgNr = reader.GetValue(4).ToString();

                                    context.Customer.Add(newCustomer);
                                }
                            }
                            catch (Exception ex)
                            {
                                System.Console.WriteLine(ex.Message);
                            }
                        }
                        reader.Close();
                    }

                    connection.Close();
                    context.SaveChanges();
                }
            }
        }

        public void GetData(SqlCommand results)
        {
        }
    }
}