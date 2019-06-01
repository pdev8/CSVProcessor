using System;
using System.Collections.Generic;
using System.Linq;
using Unity;

namespace CSVProcessor
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = ApplicationStart.Initialize();

            var csvReader = container.Resolve<ICSVReader>();

            Console.WriteLine("Enter the path:");
            var path = Console.ReadLine();

            var lines = csvReader.ReadCSV(path);

            var data = new CustomCSVClass(lines);
            var columnNames = data.headers.Skip(1);

            var totalData = new List<IEnumerable<string>>();

            foreach (var column in columnNames)
            {
                var columnData = data[column];

                totalData.Add(columnData);
            }

            Console.ReadKey();
        }
    }
}