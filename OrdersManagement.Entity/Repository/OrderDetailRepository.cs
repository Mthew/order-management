using OrdersManagement.Entity.DTO;
using OrdersManagement.Entity.Models;

namespace OrdersManagement.Entity.Repository
{
    public class OrderDetailRepository
    {
        #region GET

        public OrderDetailToPrintDTO GetById(int orderID)
        {
            using (DbOrdersContext db = new DbOrdersContext())
            {
                return (from o in db.Orders
                        join od in db.OrderDetails on o.Id equals od.OrderId
                        where od.Id.Equals(orderID)
                        select new OrderDetailToPrintDTO()
                        {
                            Id = o.Id,
                            CampaignNumber = o.CampaignNumber,
                            OrderNumber = o.OrderNumber,
                            OmNumber = o.OmNumber,
                            Generic = o.Generic,
                            Variant = od.Variant,
                            ConfirmedQuantity = (int)od.ConfirmedQuantity!,
                            Size = od.Size,
                            ColorCode = od.ColorCode,
                            BarCode = od.BarCode,
                        }).FirstOrDefault()!;
            }
        }


        #endregion

        #region POST


        #endregion

        #region PUT

        public void AddQuantity(int orderID, string barcode, int quantity)
        {
            using (DbOrdersContext db = new DbOrdersContext())
            {
                OrderDetail item = db.OrderDetails.FirstOrDefault(x => x.OrderId.Equals(orderID) && x.BarCode.Equals(barcode))!;

                if (item == null)
                {
                    throw new Exception($"El código de barras {barcode}, no se encuntra ingresado en esta programación");
                }

                item.ConfirmedQuantity += quantity;

                db.SaveChanges();
            }
        }

        public void AddQuantityPrinted(int orderID, string barcode)
        {
            using (DbOrdersContext db = new DbOrdersContext())
            {
                OrderDetail item = db.OrderDetails.FirstOrDefault(x => x.OrderId.Equals(orderID) && x.BarCode.Equals(barcode))!;

                if (item == null)
                {
                    throw new Exception($"El código de barras {barcode}, no se encuntra ingresado en esta programación");
                }

                item.PrintedQuantity += item.ConfirmedQuantity;
                item.ConfirmedQuantity = 0;

                db.SaveChanges();
            }
        }

        #endregion

        #region DELETE

        #endregion

        #region Private methods
        #endregion
    }
}
