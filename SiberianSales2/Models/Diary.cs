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
        public Client Client { get; set; }
        public DateTime RealizationDate { get; set; }
        public long Content { get; set; }

        public Diary()
        {
        }

        public Diary(int id, Seller seller, Client client, DateTime realizationDate, long content)
        {
            Id = id;
            Seller = seller;
            Client = client;
            RealizationDate = realizationDate;
            Content = content;
        }
    }
}
