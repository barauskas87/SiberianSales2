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
        public Client Client { get; set; }
        public DateTime ScheduleDate { get; set; }
        public string Objetive { get; set; }

        public Scheduling()
        {
        }

        public Scheduling(int id, Seller seller, Client client, DateTime scheduleDate, string objetive)
        {
            Id = id;
            Seller = seller;
            Client = client;
            ScheduleDate = scheduleDate;
            Objetive = objetive;
        }
    }
}
