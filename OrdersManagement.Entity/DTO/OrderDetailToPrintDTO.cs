using OrdersManagement.Entity.Models;

namespace OrdersManagement.Entity.DTO
{
    public class OrderDetailToPrintDTO
    {
        public int Id { get; set; }

        public int OrderId { get; set; }

        public string BarCode { get; set; } = null!;

        public string Sku { get; set; } = null!;

        public string Color { get; set; } = null!;

        public string ColorCode { get; set; } = null!;

        public string Variant { get; set; } = null!;

        public string Size { get; set; } = null!;

        public int UmQuantity { get; set; }

        public int RealQuantity { get; set; }

        public string OfNumber { get; set; } = null!;

        public int ConfirmedQuantity { get; set; }

        public string CampaignNumber { get; set; } = null!;
        public string OrderNumber { get; set; } = null!;
        public string OmNumber { get; set; } = null!;
        public string Generic { get; set; } = null!;
    }
}
