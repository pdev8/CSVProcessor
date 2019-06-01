using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSVProcessor
{
    public class CSVContext : DbContext
    {
        public CSVContext() : base("name=DefaultConnection")
        {
        }

        public DbSet<CustomCSVClass> Unknown { get; set; }
    }
}