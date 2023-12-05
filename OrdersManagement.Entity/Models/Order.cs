using System;
using System.Collections.Generic;

namespace OrdersManagement.Entity.Models;

public partial class Order
{
    public int Id { get; set; }

    public string OrderNumber { get; set; } = null!;

    public string OmNumber { get; set; } = null!;

    public string Generic { get; set; } = null!;

    public int OrderState { get; set; }

    public DateTime? CreatedAt { get; set; }

    public virtual ICollection<OrderDetail> OrderDetails { get; } = new List<OrderDetail>();
}
