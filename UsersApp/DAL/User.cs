using System;

namespace UsersApp.DAL
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ImagePath { get; set; }
        public string Department { get; set; }
        public string Job { get; set; }
        public DateTime? Birthday { get; set; }
        public string WorkPhone { get; set; }
        public string PrivatePhone { get; set; }
        public string UserInfo { get; set; }
    }
}