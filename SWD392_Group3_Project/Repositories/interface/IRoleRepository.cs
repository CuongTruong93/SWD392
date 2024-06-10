using SWD392_Group3_Project.Entities;

namespace SWD392_Group3_Project.Repositories
{
    public interface IRoleRepository
    {
        Role FindById(int id);
        IList<Role> FindAll();
        IList<Role> SearchByName(string searchText);
        int Add(Role role);
        int Update(Role role);
        int Delete(int id);
        
    }
}
