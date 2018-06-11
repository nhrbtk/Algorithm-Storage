using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using algStorage.DAL;
using algStorage.DAL.Entities;
using algStorage.DAL.Repositories;


namespace algStorage.BLL
{
    public class UserOperation
    {
        private UserRepository userRepository;
        public UserOperation()
        {
            userRepository = new UserRepository();
        }

        public bool UserAdd(string username, string password, bool role)
        {
            try
            {
                if (!(userRepository.GetAll().Any(u => u.Username == username)))
                {

                    User user = new User
                    {
                        Username = username,
                        Password = password,
                        Role = role,
                    };

                    userRepository.Create(user);
                    userRepository.Save();
                    return true;
                }
                else
                    return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool UserDelete(int id)
        {
            try
            {
                userRepository.Delete(id);
                userRepository.Save();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool UserAuthentication(string username, string password)
        {
            try
            {
                User user = new User { Username = username, Password = password };
                if (userRepository.GetAll().Single(u=>u.Username==username).Password==password)
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

        public bool UserChangePassword(int id, string newPassword)
        {
            try
            {
                User user = userRepository.GetAll().Single(u => u.Id == id);
                user.Password = newPassword;

                userRepository.Update(user);
                userRepository.Save();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public int GetUserId(string username)
        {
            try
            {
                User user = userRepository.GetAll().Single(u => u.Username == username);
                if (user != null)
                    return user.Id;
                else
                    return 0;
            }
            catch(Exception)
            {
                return -1;
            }
        }
    }
}
