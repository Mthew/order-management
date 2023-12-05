namespace OrdersManagement.Entity.DTO
{
    //Scaffold-DbContext "server=.; database=db_orders; User ID=ticket; Password=12345; TrustServerCertificate=true" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models -Force

    public class OrderStateDTO {
        public const int NEW = 1;
        public const int CLOSED = 2;
    }

    public class OrderDTO
    {
        public int Id { get; set; }

        public string OrderNumber { get; set; } = null!;

        public string OmNumber { get; set; } = null!;

        public string Generic { get; set; } = null!;

        public int OrderState { get; set; }

        public DateTime? CreatedAt { get; set; }

        public List<OrderDetailDTO> Details { get; set; } = null!;
    }
}
