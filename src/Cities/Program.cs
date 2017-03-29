using System;
using System.Collections.Generic;
using Cities.Comparers;

namespace Cities
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<City> cities = CityDataImporter.LoadData();

            // Swap out comparers as desired
            CompoundComparer comparer = new CompoundComparer();
            comparer.Comparers.Add(new StateComparer());
            comparer.Comparers.Add(new PopulationComparer());

            cities.Sort(comparer);

            PrintCities(cities);

            Console.ReadLine();
        }

        private static void PrintCities(IEnumerable<City> cities)
        {
            Console.WriteLine(City.GetTableHeader());

            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }

        }
    }
}
