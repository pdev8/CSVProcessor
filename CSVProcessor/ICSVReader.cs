using System.Collections.Generic;

namespace CSVProcessor
{
    public interface ICSVReader
    {
        IEnumerable<string> ReadCSV(string directory);
    }
}