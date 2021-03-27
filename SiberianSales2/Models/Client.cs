using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SiberianSales2.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string ClientName { get; set; }
        public string ClientFantasyName { get; set; }
        public int ClientCnpj { get; set; }
        public int StateInscription { get; set; }
        public bool StateInscriptionExemption { get; set; }
        public int MunicipalInscription { get; set; }
        public Address Address { get; set; }
        public string Phone { get; set; }
        public string Website { get; set; }
        public long Observation { get; set; }
        public long OrderObservation { get; set; }
        public bool ActiveClient { get; set; }
        public Seller AccountSeller { get; set; }
        public ICollection<Contact> Contacts { get; set; } = new List<Contact>();
        public ICollection<Diary> DiaryTasks { get; set; } = new List<Diary>();
        public ICollection<Scheduling> Schedules { get; set; } = new List<Scheduling>();

        public Client()
        {
        }

        public Client(int id, string clientName, string clientFantasyName, int clientCnpj, int stateInscription, bool stateInscriptionExemption, int municipalInscription, string phone, string website, long observation, long orderObservation, bool activeClient, Seller accountSeller, Address address)
        {
            Id = id;
            ClientName = clientName;
            ClientFantasyName = clientFantasyName;
            ClientCnpj = clientCnpj;
            StateInscription = stateInscription;
            StateInscriptionExemption = stateInscriptionExemption;
            MunicipalInscription = municipalInscription;
            Address = address;
            Phone = phone;
            Website = website;
            Observation = observation;
            OrderObservation = orderObservation;
            ActiveClient = activeClient;
            AccountSeller = accountSeller;
        }
    }
}
