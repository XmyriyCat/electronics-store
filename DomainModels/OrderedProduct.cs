﻿using System;
using System.Collections.Generic;

namespace AdminPanel.ModelsDb;

public class OrderedProduct
{
    public int Id { get; set; }

    public int Quantity { get; set; }

    public string? Description { get; set; }

    public int IdProduct { get; set; }

    public int IdShipment { get; set; }

    public int IdCustomer { get; set; }

    // TODO: Strange properties.

    public virtual Customer? IdCustomerNavigation { get; set; }

    public virtual Product? IdProductNavigation { get; set; }

    public virtual Shipment? IdShipmentNavigation { get; set; }
}