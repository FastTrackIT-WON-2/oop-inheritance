using System;

namespace OopInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            ExcelFile spreadSheet1 = new ExcelFile("StatDePlata", "Excel 2019");
            spreadSheet1.Open();
            spreadSheet1.PerformCalculation("A = B + C");

            PdfFile pdf1 = new PdfFile("Book1", false);
            pdf1.Open();
            pdf1.AttemptEdit();

            PdfFile pdf2 = new PdfFile("Declaratie", true);
            pdf2.Open();
            pdf2.AttemptEdit();

            FileManager.BulkCopy(@"C:\Temp", spreadSheet1, pdf1, pdf2);
        }
    }
}
