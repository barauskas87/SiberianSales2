using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SiberianSales2.Models
{
    public class Seller
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Phone2 { get; set; }
        public string Email { get; set; }
        public string Skype { get; set; }
        public string Linkedin { get; set; }
        public string Facebook { get; set; }
        public string Tweeter { get; set; }
        public DateTime BirthDate { get; set; }
        public double TxCommission { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; }
        public int DepartmentId { get; set; }
        public Reseller Reseller { get; set; }
        public int ResellerId { get; set; }
        public ICollection<Diary> Diaries { get; set; } = new List<Diary>();
        public ICollection<Goals> SellerGoals { get; set; } = new List<Goals>();
        public ICollection<Scheduling> Schedules { get; set; } = new List<Scheduling>();
        public ICollection<SalesProposal> SalesProposals { get; set; } = new List<SalesProposal>();
        public ICollection<SalesOrder> SalesOrders { get; set; } = new List<SalesOrder>();
        public ICollection<Client> Clients { get; set; } = new List<Client>();

        public Seller()
        {
        }

        public Seller(int id, string name, string phone, string phone2, string email, string skype, string linkedin, string facebook, string tweeter, DateTime birthDate, double txCommission, double baseSalary, int departmentId, int resellerId)
        {
            Id = id;
            Name = name;
            Phone = phone;
            Phone2 = phone2;
            Email = email;
            Skype = skype;
            Linkedin = linkedin;
            Facebook = facebook;
            Tweeter = tweeter;
            BirthDate = birthDate;
            TxCommission = txCommission;
            BaseSalary = baseSalary;
            DepartmentId = departmentId;
            ResellerId = resellerId;
        }

        public void AddSalesProposals(SalesProposal sp)
        {
            SalesProposals.Add(sp);
        }

        public void RemoveSalesProposals(SalesProposal sp)
        {
            SalesProposals.Remove(sp);
        }

        public void AddSalesOrders(SalesOrder so)
        {
            SalesOrders.Add(so);
        }

        public void RemoveSalesOrders(SalesOrder so)
        {
            SalesOrders.Remove(so);
        }

        public void AddClients(Client cl)
        {
            Clients.Add(cl);
        }

        public void RemoveClient(Client cl)
        {
            Clients.Remove(cl);
        }

        public void AddDiary(Diary di)
        {
            Diaries.Add(di);
        }

        public void RemoveDiary(Diary di)
        {
            Diaries.Remove(di);
        }

        public void AddSellerGoal(Goals goal)
        {
            SellerGoals.Add(goal);
        }

        public void RemoveSellerGoal(Goals goal)
        {
            SellerGoals.Remove(goal);
        }

        public void AddSchedule(Scheduling sc)
        {
            Schedules.Add(sc);
        }

        public void RemoveSchedule(Scheduling sc)
        {
            Schedules.Remove(sc);
        }

        public double TotalSales(DateTime initial, DateTime final)
        {
            return SalesOrders.Where(so => so.OrderDate >= initial && so.OrderDate <= final).Sum(so => so.SalesOrderTotalValue);
        }

        public double TotalComission(DateTime initial, DateTime final)
        {
            return SalesOrders.Where(so => so.OrderDate >= initial && so.OrderDate <= final).Sum(so => so.SalesOrderComission);
        }

        public double TotalProposal(DateTime initial, DateTime final)
        {
            return SalesProposals.Where(sp => sp.ProposalDate >= initial && sp.ProposalDate <= final).Sum(sp => sp.ProposalValue);
        }

        public double TotalProposalComission(DateTime initial, DateTime final)
        {
            return SalesProposals.Where(sp => sp.ProposalDate >= initial && sp.ProposalDate <= final).Sum(sp => sp.ProposalComissionValue);
        }
    }
}
