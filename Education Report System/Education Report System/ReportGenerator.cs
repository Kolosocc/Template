namespace Education_Report_System
{

    internal abstract class ReportGenerator
    {
        // Template Method
        public void GenerateReport()
        {
            CollectData();
            ProcessData();
            FormatReport();
            ExportReport();
        }

        protected abstract void CollectData();
        protected abstract void ProcessData();
        protected abstract void FormatReport();
        protected abstract void ExportReport();
    }

}
