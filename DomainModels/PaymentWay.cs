﻿namespace DomainModels;

public class PaymentWay
{
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public virtual ICollection<Shipment> Shipments { get; } = new List<Shipment>();
}
