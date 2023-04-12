using System;
using System.Collections.Generic;

namespace DomainModels;

public class Shipment
{
    public int Id { get; set; }

    public DateTime Date { get; set; }

    public double Cost { get; set; }

    public int IdWarehouse { get; set; }

    public int IdPaymentWay { get; set; }

    public int IdDelivery { get; set; }

    public virtual Delivery? IdDeliveryNavigation { get; set; }

    public virtual PaymentWay? IdPaymentWayNavigation { get; set; }

    public virtual Warehouse? IdWarehouseNavigation { get; set; }

    public virtual ICollection<OrderedProduct> OrderedProducts { get; } = new List<OrderedProduct>();
}
