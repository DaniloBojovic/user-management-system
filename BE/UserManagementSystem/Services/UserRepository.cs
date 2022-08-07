using Microsoft.EntityFrameworkCore;
using UserManagementSystem.Context;
using UserManagementSystem.Models;

namespace UserManagementSystem.Services
{
    public class UserRepository : IUserRepository
    {
        private UserContext _context;

        public UserRepository(UserContext context)
        {
            _context = context;
        }

        public async Task<GetAllUsersResponseModel> GetUsersAsync(UsersFilterParamsDto filterParams)
        {
            var allUsers = await _context.Users.ToListAsync();

            var sort = filterParams.SortField + " " + filterParams.SortOrder;
            switch (sort)
            {
                case "firstName 1":
                    allUsers = (from a in allUsers
                                orderby a.FirstName ascending
                               select a).ToList();
                    break;
                case "firstName -1":
                    allUsers = (from a in allUsers
                                orderby a.FirstName descending
                               select a).ToList();
                    break;
                case "lastName 1":
                    allUsers = (from a in allUsers
                                orderby a.LastName ascending
                               select a).ToList();
                    break;
                case "lastName -1":
                    allUsers = (from a in allUsers
                                orderby a.LastName descending
                               select a).ToList();
                    break;
            }

            var searchCriteria = filterParams.GlobalFilter != "null" ? filterParams.GlobalFilter : "";
            var resultBooks = allUsers.Where(x => x.Username.Contains(searchCriteria)).ToList();

            var usersFiltered = resultBooks.Skip(filterParams.StartRow).Take(filterParams.EndRow).ToList();

            return new GetAllUsersResponseModel
            {
                Users = usersFiltered,
                TotalRecords = allUsers.Count,
            };
        }

        public virtual async Task<Guid> AddUser(User userToAdd)
        {
            await _context.AddAsync(userToAdd);
            _context.SaveChanges();
            return (Guid)userToAdd.Id;
        }

        public virtual async Task<Guid> UpdateUser(User userForEdit)
        {
            var entity = _context.Users.FirstOrDefault(user => user.Id == userForEdit.Id);
            entity.FirstName = userForEdit.FirstName;
            entity.LastName = userForEdit.LastName;
            entity.Username = userForEdit.Username;
            entity.Email = userForEdit.Email;
            entity.Password = userForEdit.Password;
            entity.Status = userForEdit.Status;
            _context.Users.Update(entity);
            _context.SaveChanges();
            return (Guid)userForEdit.Id;
        }

        public async Task<Guid> DeleteUser(Guid id)
        {
            var userToDelete = _context.Users.FirstOrDefault(user => user.Id == id);
            _context.Users.Remove(userToDelete);
            _context.SaveChanges();
            return id;
        }

        public async Task<Guid> AssignUser(Guid id, bool isAdmin)
        {
            var userToAssign = _context.Users.FirstOrDefault(user => user.Id == id);
            if (userToAssign != null)
            {
                userToAssign.IsAdmin = isAdmin;
            }
            _context.SaveChanges();
            return id;
        }
    }
}
