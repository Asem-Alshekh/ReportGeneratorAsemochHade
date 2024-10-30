using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportGeneratorAsemochHade
{
    public class ReportFactory
    {
        public IReport CreateReport(string reportType)
        {
            return reportType switch
            {
                "PDF" => new PdfReport(),
                "Excel" => new ExcelReport(),
                "Word" => new WordReport(),
                "Ascidoc" => new AscidocReport(),
                _ => throw new ArgumentException("Invalid report type")
            };
        }
    }
}
