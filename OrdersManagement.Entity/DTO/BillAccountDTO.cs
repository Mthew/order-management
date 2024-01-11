namespace OrdersManagement.Entity.DTO
{
    public class BillAccountDTO
    {
        public int Id { get; set; }

        public int? OrderId { get; set; }

        public int BillNumber { get; set; }

        public DateTime? CreatedAt { get; set; }
    }
}
