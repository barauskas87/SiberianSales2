namespace SiberianSales2.Models
{
    public class PurchaseOrderStatus
    {
        public int Id { get; set; }
        public string Status { get; set; }

        public PurchaseOrderStatus(int id, string status)
        {
            Id = id;
            Status = status;
        }
    }
}
