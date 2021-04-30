namespace SiberianSales2.Models
{
    public class ComissionStatus
    {
        public int Id { get; set; }
        public string Status { get; set; }

        public ComissionStatus(int id, string status)
        {
            Id = id;
            Status = status;
        }
    }
}