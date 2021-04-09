using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SiberianSales2.Models
{
    public class Diary
    {
        public int Id { get; set; }
        public Seller Seller { get; set; }
        public int SellerId { get; set; }
        public Client Client { get; set; }
        public int ClientId { get; set; }
        public DateTime RealizationDate { get; set; }
        public string Content { get; set; }

        public Diary()
        {
        }

        public Diary(int id, int sellerId, int clientId, DateTime realizationDate, string content)
        {
            Id = id;
            SellerId = sellerId;
            ClientId = clientId;
            RealizationDate = realizationDate;
            Content = content;
        }
    }
}
