using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SiberianSales2.Models.Enums;

namespace SiberianSales2.Models
{
    public class PurchaseOrder
    {
        public int Id { get; set; }
        public string PoReference { get; set; }
        public DateTime POrderDate { get; set; }
        public DateTime PSendingDate { get; set; }
        public int PoFiscalCupom { get; set; }
        public string PoTrackingId { get; set; }
        public long PoObservation { get; set; }
        public PurchaseOrderStatus Status { get; set; }
        public double PurchaseOrderTotalValue { get; set; }
        public ICollection<PurchaseOrderItem> PurchaseOrderItems { get; set; } = new List<PurchaseOrderItem>();

        public void AddPurchaseOrderItem(PurchaseOrderItem poi)
        {
            PurchaseOrderItems.Add(poi);
        }

        public void RemovePurchaseOrderItem(PurchaseOrderItem poi)
        {
            PurchaseOrderItems.Remove(poi);
        }

        public void TotalPurchaseValue()
        {
            foreach (PurchaseOrderItem obj in PurchaseOrderItems)
            {
                PurchaseOrderTotalValue = +obj.TotalValueItem();
            }
        }

        public PurchaseOrder()
        {
        }

        public PurchaseOrder(int id, string poReference, DateTime pOrderDate, DateTime pSendingDate, int poFiscalCupom, string poTrackingId, long poObservation, PurchaseOrderStatus status, double purchaseOrderTotalValue)
        {
            Id = id;
            PoReference = poReference;
            POrderDate = pOrderDate;
            PSendingDate = pSendingDate;
            PoFiscalCupom = poFiscalCupom;
            PoTrackingId = poTrackingId;
            PoObservation = poObservation;
            Status = status;
            PurchaseOrderTotalValue = purchaseOrderTotalValue;
        }



        //Falta escrever o método para somar os valores dos itens associados a estes pedido para compor o PurchaseOrderTotalValue
    }
}
