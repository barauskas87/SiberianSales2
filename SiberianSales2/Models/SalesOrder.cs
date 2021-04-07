using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SiberianSales2.Models.Enums;

namespace SiberianSales2.Models
{
    public class SalesOrder
    {
        public int Id { get; set; }
        public Seller Seller { get; set; }
        public string Reference { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime SendingDate { get; set; }
        public int FiscalCupom { get; set; }
        public string TrackingId { get; set; }
        public int FreightTypeId { get; set; }
        public double FreightValue { get; set; }
        public long Observation { get; set; }
        public int ResellerFiscalCupom { get; set; }
        public DateTime ResellerFiscalCupomDate { get; set; }
        public SalesOrderStatus Status { get; set; }
        public double SalesOrderTotalValue { get; set; }
        public double SalesOrderComission { get; set; }
        public ICollection<SalesOrderItem> SalesOrdersItems { get; set; } = new List<SalesOrderItem>();
        public ICollection<PaymentDuplicate> PaymentDuplicates { get; set; } = new List<PaymentDuplicate>();
        public ICollection<ComissionDuplicate> ComissionDuplicates { get; set; } = new List<ComissionDuplicate>();

        public void AddSalesOrderItem(SalesOrderItem soi)
        {
            SalesOrdersItems.Add(soi);
        }
        
        public void RemoveSalesOrderItem(SalesOrderItem soi)
        {
            SalesOrdersItems.Remove(soi);
        }

        public void AddPaymentDuplicates(PaymentDuplicate pd)
        {
            PaymentDuplicates.Add(pd);
        }

        public void RemovePaymentDuplicates(PaymentDuplicate pd)
        {
            PaymentDuplicates.Remove(pd);
        }

        public void AddComissionDuplicates(ComissionDuplicate cd)
        {
            ComissionDuplicates.Add(cd);
        }

        public void RemoveComissionDuplicates(ComissionDuplicate cd)
        {
            ComissionDuplicates.Remove(cd);
        }

        public void TotalOrderValue()
        {
                foreach (SalesOrderItem obj in SalesOrdersItems)
            {
                SalesOrderTotalValue =+ obj.TotalValueProduct();
            }
        }

        public void TotalOrderComission()
        {
            foreach (SalesOrderItem obj in SalesOrdersItems)
            {
                SalesOrderComission = +obj.TotalComissionProduct();
            }
        }

        public SalesOrder()
        {
        }

        public SalesOrder(int id, Seller seller, string reference, DateTime orderDate, DateTime sendingDate, int fiscalCupom, string trackingId, int freightTypeId, double freightValue, long observation, int resellerFiscalCupom, DateTime resellerFiscalCupomDate, SalesOrderStatus status, double salesOrderTotalValue, double salesOrderComission)
        {
            Id = id;
            Seller = seller;
            Reference = reference;
            OrderDate = orderDate;
            SendingDate = sendingDate;
            FiscalCupom = fiscalCupom;
            TrackingId = trackingId;
            FreightTypeId = freightTypeId;
            FreightValue = freightValue;
            Observation = observation;
            ResellerFiscalCupom = resellerFiscalCupom;
            ResellerFiscalCupomDate = resellerFiscalCupomDate;
            Status = status;
            SalesOrderTotalValue = salesOrderTotalValue;
            SalesOrderComission = salesOrderComission;
        }

        //Falta escrever o método para tirar o valor do frete da comissão quando for por nossa conta ou adicionar ao valor total do pedido quando for por conta do cliente e destacar o frete
    }
}
