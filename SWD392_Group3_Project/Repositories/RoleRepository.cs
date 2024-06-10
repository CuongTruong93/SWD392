using SWD392_Group3_Project.Entities;

namespace SWD392_Group3_Project.Repositories
{
    public class RoleRepository : IRoleRepository
    {

        private readonly RestaurantManagementContext _context;
        public RoleRepository(RestaurantManagementContext context)
        {
            _context = context;
        }
        public int Add(Role role)
        {
            _context.Roles.Add(role);
            int result = _context.SaveChanges();
            return result;
        }

        public int Delete(int id)
        {
            _context.Roles.Remove(FindById(id));
            int result = _context.SaveChanges();
            return result;
        }

        public IList<Role> FindAll()
        {
            List<Role> roles = _context.Roles.ToList();
            return roles;
        }

        public Role FindById(int id)
        {
            Role role = _context.Roles.FirstOrDefault(r => r.RoleId == id);
            return role;
        }

        public IList<Role> SearchByName(string searchText)
        {
            throw new NotImplementedException();
        }

        public int Update(Role role)
        {
            _context.Roles.Update(role);
            int result = _context.SaveChanges();
            return result;
        }
    }
}
