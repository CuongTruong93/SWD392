using SWD392_Group3_Project.Entities;

namespace SWD392_Group3_Project.Repositories
{
    public interface IUserRepository
    {
        User FindById(int id);
        IList<User> FindAll();
        IList<User> SearchByName(string searchText);
        int Add(User user);
        int Update(User user);
        int Delete(int id);
        User Authenticate(string username, string password);
    }
}
