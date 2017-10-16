using System.Collections.Generic;
using System.Web.Http;
using UsersApp.DAL;
using UsersApp.Responses;

namespace UsersApp.ControllersWebApi
{
    [Authorize]
    public class DataController : ApiController
    {
        private IUsersAppDao _data;
        private IUsersAppDao DataManager
        {
            get {
                if (_data == null)
                {
                    _data = new UsersAppDao();

                }
                return _data;
            }
        }
        
        public List<User> GetUsers(int? id)
        {
            if(id == null)
            {
                return DataManager.GetAllUsers();
            }
            else
            {
                return new List<User>() { DataManager.GetUserById((int)id) };
            }
            
        }

        [Route("api/Data/UsersRange/{start}/{amount}")]
        public UsersRangeResponse GetUsersRange(int start, int amount)
        {
            UsersRangeResponse response = new UsersRangeResponse();
            response.UsersList = DataManager.GetSpecifiedUsers(start, amount);
            response.UsersTotal = DataManager.GetUsersAmount();

            return response;
        }
    }    
}
