using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SiberianSales2.Models
{
    public class Contact
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Phone { get; set; }
        public int Extension { get; set; }
        public string Email { get; set; }
        public int Whatsapp { get; set; }
        public string Skype { get; set; }
        public string Linkedin { get; set; }
        public string Facebook { get; set; }
        public string Tweeter { get; set; }
        public DateTime BirthDate { get; set; }
        public Client Client { get; set; }

        public Contact()
        {
        }

        public Contact(int id, string name, int phone, int extension, string email, int whatsapp, string skype, string linkedin, string facebook, string tweeter, DateTime birthDate, Client client)
        {
            Id = id;
            Name = name;
            Phone = phone;
            Extension = extension;
            Email = email;
            Whatsapp = whatsapp;
            Skype = skype;
            Linkedin = linkedin;
            Facebook = facebook;
            Tweeter = tweeter;
            BirthDate = birthDate;
            Client = client;
        }
    }
}
