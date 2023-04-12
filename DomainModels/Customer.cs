using System;
using System.Collections.Generic;

namespace AdminPanel.ModelsDb;

public class Customer
{
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public string? PhoneNumber { get; set; }

    public string Address { get; set; } = string.Empty;

    public virtual ICollection<OrderedProduct> OrderedProducts { get; } = new List<OrderedProduct>();
}
