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
        public string ClientCnpj { get; set; }
        public string StateInscription { get; set; }
        public bool StateInscriptionExemption { get; set; }
        public string MunicipalInscription { get; set; }
        public int AddressId { get; set; }
        public string Phone { get; set; }
        public string Website { get; set; }
        public string Observation { get; set; }
        public string OrderObservation { get; set; }
        public bool ActiveClient { get; set; }
        public int AccountSellerId { get; set; }
        public ICollection<Contact> Contacts { get; set; } = new List<Contact>();
        public ICollection<Diary> DiaryTasks { get; set; } = new List<Diary>();
        public ICollection<Scheduling> Schedules { get; set; } = new List<Scheduling>();

        public Client()
        {
        }

        public Client(int id, string clientName, string clientFantasyName, string clientCnpj, string stateInscription, bool stateInscriptionExemption, string municipalInscription, string phone, string website, string observation, string orderObservation, bool activeClient, int accountSellerId, int addressId)
        {
            Id = id;
            ClientName = clientName;
            ClientFantasyName = clientFantasyName;
            ClientCnpj = clientCnpj;
            StateInscription = stateInscription;
            StateInscriptionExemption = stateInscriptionExemption;
            MunicipalInscription = municipalInscription;
            AddressId = addressId;
            Phone = phone;
            Website = website;
            Observation = observation;
            OrderObservation = orderObservation;
            ActiveClient = activeClient;
            AccountSellerId = accountSellerId;
        }
    }
}
