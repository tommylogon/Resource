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
        public List<Tuple<int, List<string>, List<string>>> Row;

        public CustomerData CustomerDatas { get; set; } = new CustomerData();

        public class CustomerData
        {
            public List<double> CustomerMentionings { get; set; } = new List<double>();
            public List<string> CustomerNames { get; set; } = new List<string>();
            public List<DateTime> ActiveToDates { get; set; } = new List<DateTime>();
        }

        public async Task OnGetAsync(string searchString)
        {
            DataAccessLayer dataAccess = new DataAccessLayer();
            Row = dataAccess.GetCustomersHavingMachines("select top(1000)  CUSTOMER.OBJ_NO, CUSTOMER.CUSTOMER_NAME, Customer.SEARCH_NAME, MACHINE.OBJ_NO as 'Machine OBJ_NO', ADDRESS.ADDRESS_CODE, ADDRESS.ADDRESS_NAME, ADDRESS_1, ADDRESS_2, ADDRESS.POSTAL_CODE, MACHINE.INSTALLATION_DATE, MACHINE.ACTIVE_FROM, MACHINE.ACTIVE_TO, MACHINE.LOCATION from ADDRESS inner join machine on ADDRESS.Source_obj_no = machine.Customer_obj_no inner join CUSTOMER on Customer.OBJ_NO = machine.CUSTOMER_OBJ_NO ");

            foreach (Tuple<int, List<string>, List<string>> tuple in Row)
            {
                DateTime currentDate = DateTime.Now;
                DateTime activeTo;
                DateTime.TryParse(tuple?.Item2[11], out activeTo);
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
            GenerateBarChart();
            GeneratePieChart();
        }

        public void GenerateBarChart()
        {
            Chart barChart = new Chart();
            barChart.Type = "bar";
            Data barData = new Data();
            List<string> years = new List<string>();

            foreach (DateTime dt in CustomerDatas.ActiveToDates)
            {
                years.Add(dt.Year.ToString());
            }
            barData.Labels = years;

            BarDataset dataset = new BarDataset()
            {
                Label = "Years",
                Data = CustomerDatas.CustomerMentionings,
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
            ViewData["bar"] = barData;
        }

        public void GeneratePieChart()
        {
            Chart pieChart = new Chart();
            pieChart.Type = "pie";
            Data pieData = new Data();

            pieData.Labels = CustomerDatas.CustomerNames;

            PieDataset dataset = new PieDataset()
            {
                Label = "Customer with the most machines",
                Data = CustomerDatas.CustomerMentionings,
                BackgroundColor = new List<string>() { "#f0f8ff", "#007bff", "#dc3545", "#ffc107", "#28a745" }
            };
            pieData.Datasets = new List<Dataset>();

            pieData.Datasets.Add(dataset);

            pieChart.Data = pieData;

            ViewData["chart"] = pieChart;
        }
    }
}