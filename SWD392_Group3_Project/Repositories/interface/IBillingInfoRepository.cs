using SWD392_Group3_Project.Entities;

namespace SWD392_Group3_Project.Repositories
{
    public interface IBillingInfoRepository
    {
        BillingInfo FindById(int id);
        IList<BillingInfo> FindAll();
        IList<BillingInfo> SearchByName(string searchText);
        int Add(BillingInfo billingInfo);
        int Update(BillingInfo billingInfo);
        int Delete(int id);
    }
}
