using System.Collections.Generic;

namespace UsersApp.DAL
{
    interface IUsersAppDao
    {
        User GetUserById(int id);

        List<User> GetAllUsers();

        void UpdateUserById(User user, int id);

        void RemoveUserById(int id);

        void AddUser(User user);

        List<User> GetSpecifiedUsers(int skip, int take);

        int GetUsersAmount();
    }
}
