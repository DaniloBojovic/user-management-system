using UserManagementSystem.Models;

namespace UserManagementSystem.Services
{
    public interface IUserRepository
    {
        Task<GetAllUsersResponseModel> GetUsersAsync(UsersFilterParamsDto filterParams);
        Task<Guid> AddUser(User userToAdd);
        Task<Guid> UpdateUser(User userForEdit);
        Task<Guid> DeleteUser(Guid id);
        Task<Guid> AssignUser(Guid id, bool isAdmin);

    }
}
