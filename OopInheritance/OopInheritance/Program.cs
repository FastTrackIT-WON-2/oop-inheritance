using System;

namespace OopInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape t = new Triangle(new Point(15, 15), new Point(23, 30), new Point(50, 25));
            Console.WriteLine($"Triangle Area: {t.Area}");
            t.Rotate(45);
            Console.WriteLine($"Triangle Area: {t.Area}");

            Shape r = new Rectangle(new Point(10, 10), 20, 10);
            Console.WriteLine($"Rectangle Area: {r.Area}");
            r.Rotate(45);
            Console.WriteLine($"Rectangle Area: {r.Area}");

            /*

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

            */

        }
    }
}
