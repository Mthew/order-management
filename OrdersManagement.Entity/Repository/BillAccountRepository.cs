using OrdersManagement.Entity.DTO;
using OrdersManagement.Entity.Models;

namespace OrdersManagement.Entity.Repository
{
    public class BillAccountRepository
    {
        #region GET

        public List<BillAccountDTO> getAll()
        {
            using (DbOrdersContext db = new DbOrdersContext())
            {
                return db.BillAccounts.Select(x => ModelToDto(x)).ToList();
            }
        }

        public BillAccountDTO getById(int id)
        {
            using (DbOrdersContext db = new DbOrdersContext())
            {
                return db.BillAccounts.Where(x => x.Id.Equals(id)).Select(x => ModelToDto(x)).FirstOrDefault()!;
            }
        }

        public int getLastbillAccountNumber()
        {
            using (var db = new DbOrdersContext())
            {
                return db.BillAccounts.Max(x => x.BillNumber);
            }
        }

        #endregion

        #region POST

        public void Create(BillAccount dto)
        {
            using (DbOrdersContext db = new DbOrdersContext())
            {
                BillAccount item = new BillAccount();

                item.Id = dto.Id;
                item.OrderId = dto.OrderId;
                item.BillNumber = db.BillAccounts.Max(x => x.BillNumber) + 1;

                db.BillAccounts.Add(item);
                db.SaveChanges();

                dto.Id = item.Id;
            }
        }

        #endregion

        #region PUT





        #endregion

        #region DELETE
        public void Remove(int billAccountId)
        {
            using (DbOrdersContext db = new DbOrdersContext())
            {
                BillAccount item = db.BillAccounts.FirstOrDefault(x => x.Id.Equals(billAccountId))!;

                if (item == null)
                {
                    throw new Exception("Item not found");
                }

                db.BillAccounts.Remove(item);
                db.SaveChanges();
            }
        }
        #endregion

        #region Private methods
        private BillAccountDTO ModelToDto(BillAccount x)
        {
            return new BillAccountDTO()
            {
                Id = x.Id,
                OrderId = (int)x.OrderId!,
                BillNumber = x.BillNumber,
                CreatedAt = x.CreatedAt,
            };
        }
        #endregion
    }
}
