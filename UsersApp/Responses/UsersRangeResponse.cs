using System.Collections.Generic;
using UsersApp.DAL;

namespace UsersApp.Responses
{
    public class UsersRangeResponse
    {
        public int UsersTotal { get; set; }
        public List<User> UsersList { get; set; }
    }
}