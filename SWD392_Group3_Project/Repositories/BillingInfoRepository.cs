using SWD392_Group3_Project.Entities;

namespace SWD392_Group3_Project.Repositories
{
    public class BillingInfoRepository :IBillingInfoRepository
    {
        private readonly RestaurantManagementContext _context;
        public BillingInfoRepository(RestaurantManagementContext context)
        {
            _context = context;
        }

        public int Add(BillingInfo billingInfo)
        {
            _context.BillingInfos.Add(billingInfo);
            int result = _context.SaveChanges();
            return result;
        }

        public int Delete(int id)
        {
            _context.BillingInfos.Remove(FindById(id));
            int result = _context.SaveChanges();
            return result;
        }

        public IList<BillingInfo> FindAll()
        {
            List<BillingInfo> billingInfos = _context.BillingInfos.ToList();
            return billingInfos;
        }

        public BillingInfo FindById(int id)
        {
           BillingInfo billingInfo = _context.BillingInfos.FirstOrDefault(b =>b.BillingId == id);
            return billingInfo;
        }

        public IList<BillingInfo> SearchByName(string searchText)
        {
            throw new NotImplementedException();
        }

        public int Update(BillingInfo billingInfo)
        {
            _context.BillingInfos.Update(billingInfo);
            int result = _context.SaveChanges();
            return result;
        }
    }
}
