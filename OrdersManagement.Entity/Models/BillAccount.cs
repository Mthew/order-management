using System;
using System.Collections.Generic;

namespace OrdersManagement.Entity.Models;

public partial class BillAccount
{
    public int Id { get; set; }

    public int? OrderId { get; set; }

    public int BillNumber { get; set; }

    public decimal Price { get; set; }

    public DateTime? CreatedAt { get; set; }
}
