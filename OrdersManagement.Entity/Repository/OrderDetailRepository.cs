using OrdersManagement.Entity.DTO;
using OrdersManagement.Entity.Models;

namespace OrdersManagement.Entity.Repository
{
    public class OrderDetailRepository
    {
        #region GET

       

        #endregion

        #region POST


        #endregion

        #region PUT

        public void AddQuantity(string barcode, int quantity)
        {
            using (DbOrdersContext db = new DbOrdersContext())
            {
                OrderDetail item = db.OrderDetails.FirstOrDefault(x => x.BarCode.Equals(barcode))!;

                if (item == null)
                {
                    throw new Exception("Item not found");
                }

                item.ConfirmedQuantity += quantity;

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
