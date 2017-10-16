using UsersApp.DAL;

namespace UsersApp.Requests
{
    public class UpdateUserRequest
    {
        public int UserId { get; set; }
        public User User { get; set; }
    }
}