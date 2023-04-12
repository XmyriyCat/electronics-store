using System;
using System.Collections.Generic;

namespace AdminPanel.ModelsDb;

public class Delivery
{
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public double Cost { get; set; }

    public string? Description { get; set; }

    public virtual ICollection<Shipment> Shipments { get; } = new List<Shipment>();
}
