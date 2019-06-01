using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CSVProcessor
{
    public class CSVReader : ICSVReader
    {
        public IEnumerable<string> ReadCSV(string directory)
        {
            var csvFile = Directory.GetFiles(directory).FirstOrDefault(s => !string.IsNullOrWhiteSpace(s) && s.Contains("csv"));

            var lines = File.ReadAllLines(csvFile);

            return lines;
        }
    }
}