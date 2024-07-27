namespace Lab07.Models
{
    public class CategoryStatistics
    {
        public string Category { get;set ; }
        public int NumOfProduct { get;set ; }
    }

    public class SupplierCategoryStatistics
    {
        public string Supplier { get; set; }
        public string Category { get; set; }
        public int NumOfProduct { get; set; }
    }
}
