using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SiberianSales2.Models
{
    public class Scheduling
    {
        public int Id { get; set; }
        public Seller Seller { get; set; }
        public int SellerId { get; set; }
        public Client Client { get; set; }
        public int ClientId { get; set; }
        public DateTime ScheduleDate { get; set; }
        public string Objetive { get; set; }

        public Scheduling()
        {
        }

        public Scheduling(int id, int sellerId, int clientId, DateTime scheduleDate, string objetive)
        {
            Id = id;
            SellerId = sellerId;
            ClientId = clientId;
            ScheduleDate = scheduleDate;
            Objetive = objetive;
        }
    }
}
