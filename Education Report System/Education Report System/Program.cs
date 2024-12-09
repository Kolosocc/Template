
using Education_Report_System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Генерация отчета о студентах:");
        ReportGenerator studentReport = new StudentReportGenerator();
        studentReport.GenerateReport();

        Console.WriteLine("\nГенерация отчета о курсах:");
        ReportGenerator courseReport = new CourseReportGenerator();
        courseReport.GenerateReport();
    }
}
