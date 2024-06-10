using Microsoft.AspNetCore.Mvc.ModelBinding;
using SWD392_Group3_Project.Entities;

namespace SWD392_Group3_Project.Repositories
{
    public class UserRepository : IUserRepository
    {

        private readonly RestaurantManagementContext _context;
        public UserRepository(RestaurantManagementContext context)
        {
            _context = context;
        }


        public int Add(User user)
        {
            _context.Users.Add(user);
            int result = _context.SaveChanges();
            return result;
        }

        public int Delete(int id)
        {
            _context.Users.Remove(FindById(id));
            int result = _context.SaveChanges();
            return result;
        }

        public IList<User> FindAll()
        {
            List<User> users = _context.Users.ToList();
            return users;
        }

        public User FindById(int id)
        {
            User user = _context.Users.FirstOrDefault(u => u.UserId == id);
            return user;
        }

        public IList<User> SearchByName(string searchText)
        {
            throw new NotImplementedException();
        }

        public int Update(User user)
        {
            _context.Users.Update(user);
            int result = _context.SaveChanges();
            return result;
        }
        public User Authenticate(string username, string password)
        {
            var user = _context.Users.FirstOrDefault(u => u.Username == username && u.PasswordHash == password);
            return user;
        }
    }
}
