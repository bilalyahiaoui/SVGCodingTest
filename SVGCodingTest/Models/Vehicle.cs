using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SVGCodingTest.Models
{
    public class Vehicle
    {
        public string VehicleType { get; set; }
        public int Sales2018 { get; set; }
        public int Sales2019 { get; set; }

        private decimal TotalOfSales2019(List<Vehicle> vehicles)
        {
            decimal total = 0;
            foreach(var vehicle in vehicles)
            {
                total += vehicle.Sales2019;
            }
            return total;
        }

        List<decimal> TotalMarketShare { get; set; }

        public List<decimal> MarketShare2019(List<Vehicle> vehicles)
        {
            List<decimal> final = new List<decimal>();
            foreach (var vehicle in vehicles)
            {
                    decimal sales = vehicle.Sales2019;
                    decimal totalSales = TotalOfSales2019(vehicles);
                    decimal marketShare = sales / totalSales;
                    marketShare = Math.Round(marketShare, 2);
                    marketShare = marketShare * 100;
                    final.Add(marketShare);

            }
            return final;
        }
    }
}
