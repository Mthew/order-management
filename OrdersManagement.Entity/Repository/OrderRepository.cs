using OrdersManagement.Entity.DTO;
using OrdersManagement.Entity.Models;

namespace OrdersManagement.Entity.Repository
{
    public class OrderRepository
    {
        #region GET

        public List<OrderDTO> getAll()
        {
            using (DbOrdersContext db = new DbOrdersContext())
            {
                return db.Orders.Select(x => OrderToDto(x)).ToList();
            }
        }



        public OrderDTO getById(int orderId)
        {
            using (DbOrdersContext db = new DbOrdersContext())
            {
                return db.Orders.Where(x => x.Id.Equals(orderId)).Select(x => new OrderDTO()
                {
                    Id = x.Id,
                    OrderNumber = x.OrderNumber,
                    OmNumber = x.OmNumber,
                    Generic = x.Generic,
                    OrderState = x.OrderState,
                    CreatedAt = x.CreatedAt,
                    CampaignNumber = x.CampaignNumber,
                    Details = x.OrderDetails.Select(d => new OrderDetailDTO()
                    {
                        Id = d.Id,
                        OrderId = d.OrderId,
                        BarCode = d.BarCode,
                        Sku = d.Sku,
                        Color = d.Color,
                        ColorCode = d.ColorCode,
                        Variant = d.Variant,
                        Size = d.Size,
                        UmQuantity = d.UmQuantity,
                        RealQuantity = d.RealQuantity,
                        OfNumber = d.OfNumber,
                        ConfirmedQuantity = (int)d.ConfirmedQuantity!,
                        PrintedQuantity = (int)d.PrintedQuantity!,
                    }).ToList()
                }).FirstOrDefault()!;
            }
        }

        public List<OrderDTO> filter(string concept)
        {
            using (DbOrdersContext db = new DbOrdersContext())
            {
                return db.Orders.Where(x => new string[] { x.Generic, x.OrderNumber, x.OmNumber }.Contains(concept)).Select(x => OrderToDto(x)).ToList();
            }
        }

        #endregion

        #region POST

        public void Create(OrderDTO dto)
        {
            using (DbOrdersContext db = new DbOrdersContext())
            {
                Order order = new Order();

                order.OrderNumber = dto.OrderNumber;
                order.OmNumber = dto.OmNumber;
                order.Generic = dto.Generic;
                order.OrderState = dto.OrderState;
                order.CampaignNumber = dto.CampaignNumber;

                db.Orders.Add(order);
                db.SaveChanges();

                dto.Id = order.Id;

                this.AddDetails(db, dto.Id, dto.Details);

            }
        }

        #endregion

        #region PUT

        public void Update(OrderDTO dto)
        {
            using (DbOrdersContext db = new DbOrdersContext())
            {
                Order order = db.Orders.FirstOrDefault(x => x.Id.Equals(dto.Id))!;

                if (order == null)
                {
                    throw new Exception("Item not found");
                }

                order.OrderNumber = dto.OrderNumber;
                order.OmNumber = dto.OmNumber;
                order.Generic = dto.Generic;
                order.OrderState = dto.OrderState;
                order.CampaignNumber = dto.CampaignNumber;

                this.AddDetails(db, order.Id, dto.Details);
            }
        }

        public void AddDetails(DbOrdersContext db, int orderId, List<OrderDetailDTO> dtos)
        {
            var orderDetails = db.OrderDetails.Where(x => x.OrderId.Equals(orderId));
            if (orderDetails.Any())
            {
                db.RemoveRange(orderDetails);
                db.SaveChanges();
            }

            db.OrderDetails.AddRange(dtos.Select(x => new OrderDetail()
            {
                OrderId = orderId,
                BarCode = x.BarCode,
                Sku = x.Sku,
                Color = x.Color,
                ColorCode = x.ColorCode,
                Variant = x.Variant,
                Size = x.Size,
                UmQuantity = x.UmQuantity,
                RealQuantity = x.RealQuantity,
                OfNumber = x.OfNumber,
            }));
            db.SaveChanges();
        }

        #endregion

        #region DELETE
        public void Remove(int orderId)
        {
            using (DbOrdersContext db = new DbOrdersContext())
            {
                Order order = db.Orders.FirstOrDefault(x => x.Id.Equals(orderId))!;

                if (order == null)
                {
                    throw new Exception("Item not found");
                }

                db.Orders.Remove(order);
                db.SaveChanges();
            }
        }
        #endregion

        #region Private methods
        private static OrderDTO OrderToDto(Order x)
        {
            return new OrderDTO()
            {
                Id = x.Id,
                OrderNumber = x.OrderNumber,
                OmNumber = x.OmNumber,
                Generic = x.Generic,
                OrderState = x.OrderState,
                CreatedAt = x.CreatedAt,
                CampaignNumber = x.CampaignNumber,  
            };
        }
        #endregion
    }
}
