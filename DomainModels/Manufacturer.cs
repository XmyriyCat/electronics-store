using System;
using System.Collections.Generic;

namespace AdminPanel.ModelsDb;

public class Manufacturer
{
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public virtual ICollection<Product> Products { get; } = new List<Product>();
}
