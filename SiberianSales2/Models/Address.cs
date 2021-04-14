using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SiberianSales2.Models
{
    public class Address
    {
        public int Id { get; set; }
        public string AddressName { get; set; }
        public string AddessNumber { get; set; }
        public string AddressComplement { get; set; }
        public string District { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }

        public Address()
        {
        }

        public Address(int id, string addressName, string addessNumber, string addressComplement, string district, string city, string state, string postalCode)
        {
            Id = id;
            AddressName = addressName;
            AddessNumber = addessNumber;
            AddressComplement = addressComplement;
            District = district;
            City = city;
            State = state;
            PostalCode = postalCode;
        }

        public override string ToString()
        {
            return AddressName + ", " + AddessNumber + ", " + City + " - " + State;
        }
    }
}
