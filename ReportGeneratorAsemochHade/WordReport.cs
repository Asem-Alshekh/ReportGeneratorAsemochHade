using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportGeneratorAsemochHade
{
    public class WordReport : IReport
    {
        public void Generate() => Console.WriteLine("Word Report Generated.");
    }
}
