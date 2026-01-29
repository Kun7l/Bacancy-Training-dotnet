using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Day_3
{
    internal abstract class ReportGenerator
    {
        public abstract void GenerateReport();
    }

    class PDFReport : ReportGenerator
    {
        public override void GenerateReport() => Console.WriteLine("Generating report as PDF file");
    }

    class ExcelReport : ReportGenerator
    {
        public override void GenerateReport() => Console.WriteLine("Generating report as Excel file");
    }

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        PDFReport reportPdf = new PDFReport();
    //        reportPdf.GenerateReport();

    //        ExcelReport excelReport = new ExcelReport();
    //        excelReport.GenerateReport();
    //    }
    //}
}
