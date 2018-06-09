using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using algStorage.DAL.Repositories;

namespace algStorage.BLL
{
    public class UserSingIn
    {
        private UserRepository userRepository;
        public UserSingIn()
        {
            userRepository = new UserRepository();
        }

        public bool UserAuthentication(string username, string password)
        {
            try
            {
                if (userRepository.GetAll().Single(u => u.Username == username).Password == password)
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool UserAuthorization(string username)
        {
            try
            {
                return userRepository.GetAll().Single(u => u.Username == username).Role;
            }
            catch (Exception)
            {
                return false;
            }
        }

    }
}
