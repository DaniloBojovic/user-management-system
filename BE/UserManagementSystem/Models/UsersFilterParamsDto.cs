namespace UserManagementSystem.Models
{
    public class UsersFilterParamsDto
    {
        public int StartRow { get; set; }

        public int EndRow { get; set; }
        public string SortField { get; set; }
        public int SortOrder { get; set; }
        public string GlobalFilter { get; set; }
    }
}
