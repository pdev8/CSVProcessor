using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;

namespace CSVProcessor
{
    public class CustomCSVClass : DynamicObject
    {
        public readonly IEnumerable<string> headers;

        public readonly IEnumerable<string> rows;

        public CustomCSVClass(IEnumerable<string> lines)
        {
            this.headers = lines.ToArray()[0].Split(',');
            this.rows = lines.ToArray().Skip(1);
        }

        public IEnumerable<string> this[string indexer]
        {
            get
            {
                var result = new[]
                {
                    string.Empty
                };

                var index = Array.FindIndex(this.headers.ToArray(), s => s.IndexOf(indexer, StringComparison.OrdinalIgnoreCase) >= 0);

                if (index >= 0 && index < rows.Count())
                {
                    result = rows.Select(s => s.Split(',')[index]).ToArray();
                }
               
                return result;
            }
        }
    }
}