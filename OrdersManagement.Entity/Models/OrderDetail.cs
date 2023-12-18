using System;
using System.Collections.Generic;

namespace OrdersManagement.Entity.Models;

public partial class OrderDetail
{
    public int Id { get; set; }

    public int OrderId { get; set; }

    public string BarCode { get; set; } = null!;

    public string Sku { get; set; } = null!;

    public string OfNumber { get; set; } = null!;

    public string Color { get; set; } = null!;

    public string ColorCode { get; set; } = null!;

    public string Variant { get; set; } = null!;

    public string Size { get; set; } = null!;

    public int UmQuantity { get; set; }

    public int RealQuantity { get; set; }

    public int? ConfirmedQuantity { get; set; }

    public int? PrintedQuantity { get; set; }

    public string? Description { get; set; }

    public decimal Price { get; set; }

    public virtual Order Order { get; set; } = null!;
}
