using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChartJSCore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Resource.Models;

namespace Resource.Pages.Panel
{
    public class CustomerOverviewModel : PageModel
    {
        public List<Tuple<int, List<string>, List<string>>> Row = new List<Tuple<int, List<string>, List<string>>>();
        public List<Tuple<int, List<string>, List<string>>> RowProject;

        public CustomerData CustomerDatas { get; set; } = new CustomerData();

        public int IndexOfActiveTo = 11;

        public class CustomerData
        {
            public List<double> CustomerMentionings { get; set; } = new List<double>();
            public List<string> CustomerNames { get; set; } = new List<string>();
            public List<DateTime> ActiveToDates { get; set; } = new List<DateTime>();
            public List<double> DateMentionings { get; set; } = new List<double>();
        }

        public async Task OnGetAsync(string searchString)
        {
            DataAccessLayer dataAccess = new DataAccessLayer();
            Row = new List<Tuple<int, List<string>, List<string>>>(dataAccess.GetCustomersHavingMachines("select  CUSTOMER.OBJ_NO, CUSTOMER.CUSTOMER_NAME, Customer.SEARCH_NAME, MACHINE.OBJ_NO as 'Machine OBJ_NO', ADDRESS.ADDRESS_CODE, ADDRESS.ADDRESS_NAME, ADDRESS_1, ADDRESS_2, ADDRESS.POSTAL_CODE, MACHINE.INSTALLATION_DATE, MACHINE.ACTIVE_FROM, MACHINE.ACTIVE_TO, MACHINE.LOCATION from ADDRESS inner join machine on ADDRESS.Source_obj_no = machine.Customer_obj_no inner join CUSTOMER on Customer.OBJ_NO = machine.CUSTOMER_OBJ_NO "));
            RowProject = new List<Tuple<int, List<string>, List<string>>>(dataAccess.GetDB_Data("SELECT count(STATUS), PROJECT.STATUS FROM PROJECT GROUP BY STATUS"));

            HandleCustomerData();

            GenerateBarChart();

            GeneratePieChart();
        }

        public void HandleCustomerData()
        {
            foreach (Tuple<int, List<string>, List<string>> tuple in Row)
            {
                DateTime currentDate = DateTime.Now;
                DateTime activeTo;
                try
                {
                    DateTime.TryParse(tuple.Item2[IndexOfActiveTo], out activeTo);
                    CustomerDatas.ActiveToDates.Add(activeTo);

                    if (activeTo > currentDate)
                    {
                        if (tuple.Item3[1] == "CUSTOMER_NAME")
                        {
                            if (!CustomerDatas.CustomerNames.Contains(tuple.Item2[1]))
                            {
                                CustomerDatas.CustomerNames.Add(tuple.Item2[1]);
                                CustomerDatas.CustomerMentionings.Add(1);
                            }
                            else if (CustomerDatas.CustomerNames.Contains(tuple.Item2[1]))
                            {
                                double preValue = CustomerDatas.CustomerMentionings[CustomerDatas.CustomerNames.IndexOf(tuple.Item2[1])];
                                preValue++;
                                CustomerDatas.CustomerMentionings.Insert(CustomerDatas.CustomerNames.IndexOf(tuple.Item2[1]), preValue);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                }
            }
        }

        public void GenerateBarChart()
        {
            Chart barChart = new Chart();
            barChart.Type = "bar";
            Data barData = new Data();
            List<string> years = new List<string>();

            foreach (DateTime dt in CustomerDatas.ActiveToDates)
            {
                if (!years.Contains(dt.Year.ToString()) && dt.Year.ToString() != "1")
                {
                    years.Add(dt.Year.ToString());
                    years.Sort();
                    int index = years.IndexOf(dt.Year.ToString());

                    CustomerDatas.DateMentionings.Insert(index, 1);
                }
                else if (years.Contains(dt.Year.ToString()))
                {
                    int index = years.IndexOf(dt.Year.ToString());
                    double prevVal = CustomerDatas.DateMentionings[index];
                    prevVal++;
                    CustomerDatas.DateMentionings.Insert(index, prevVal);
                }
            }
            barData.Labels = years;

            BarDataset dataset = new BarDataset()
            {
                Label = "Years",
                Data = CustomerDatas.DateMentionings,
                BackgroundColor = new List<string>() {  "rgba(255, 99, 132, 0.2)",
                                                        "rgba(54, 162, 235, 0.2)",
                                                        "rgba(255, 206, 86, 0.2)",
                                                        "rgba(75, 192, 192, 0.2)",
                                                        "rgba(153, 102, 255, 0.2)",
                                                        "rgba(255, 159, 64, 0.2)" },
            };
            barData.Datasets = new List<Dataset>();
            barData.Datasets.Add(dataset);
            barChart.Data = barData;
            ViewData["bar"] = barChart;
        }

        public void GeneratePieChart()
        {
            List<double> pieValues = new List<double>();
            foreach (Tuple<int, List<string>, List<string>> tuple in RowProject)
            {
                foreach (string value in tuple.Item2)
                {
                    if (value != "0" && value != "1")
                    {
                        pieValues.Add(Double.Parse(value));
                    }
                }
            }

            Chart pieChart = new Chart();
            pieChart.Type = "pie";
            Data pieData = new Data();

            pieData.Labels = new List<string>() { "Pending", "Completed" };

            PieDataset dataset = new PieDataset()
            {
                Label = "Customer with the most machines",
                Data = pieValues,
                BackgroundColor = new List<string>() { "#ff0000", "#00ff00" }
            };
            pieData.Datasets = new List<Dataset>();

            pieData.Datasets.Add(dataset);

            pieChart.Data = pieData;

            ViewData["chart"] = pieChart;
        }
    }
}