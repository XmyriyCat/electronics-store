using System;
using System.Collections.Generic;

namespace AdminPanel.ModelsDb;

public class PaymentWay
{
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public virtual ICollection<Shipment> Shipments { get; } = new List<Shipment>();
}
