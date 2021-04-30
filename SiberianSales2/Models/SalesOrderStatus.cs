namespace SiberianSales2.Models
{
    public class SalesOrderStatus
    {
        public int Id { get; set; }
        public string Status { get; set; }

        public SalesOrderStatus(int id, string status)
        {
            Id = id;
            Status = status;
        }
    }
}