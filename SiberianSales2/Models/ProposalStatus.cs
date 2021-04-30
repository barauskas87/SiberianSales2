namespace SiberianSales2.Models
{
    public class ProposalStatus
    {
        public int Id { get; set; }
        public string Status { get; set; }

        public ProposalStatus(int id, string status)
        {
            Id = id;
            Status = status;
        }
    }
}
