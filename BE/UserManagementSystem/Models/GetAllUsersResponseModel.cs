namespace UserManagementSystem.Models
{
    public class GetAllUsersResponseModel
    {
        public List<User> Users { get; set; }

        public int TotalRecords { get; set; }
    }
}
