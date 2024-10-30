namespace ReportGeneratorAsemochHade
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var reportFactory = new ReportFactory();

            var pdfReport = reportFactory.CreateReport("PDF");
            pdfReport.Generate();

            var excelReport = reportFactory.CreateReport("Excel");
            excelReport.Generate();

            var wordReport = reportFactory.CreateReport("Word");
            wordReport.Generate();


            var asciDocReport = reportFactory.CreateReport("Ascidoc");
            asciDocReport.Generate();



            try
            {
                var invalidReport = reportFactory.CreateReport("InvalidType");
                invalidReport.Generate();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
