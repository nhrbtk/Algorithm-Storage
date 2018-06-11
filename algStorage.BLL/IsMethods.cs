using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algStorage.BLL
{
    public static class IsMethods
    {
        public static bool IsUsername(string username)
        {
            string allowedSymbols = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789_-.";
            if (username.Length < 6 | username.Length > 20) 
                return false;
            foreach (char ch in username)
                if (!allowedSymbols.Contains(ch))
                    return false;
            return true;
        }

        public static bool IsPassword(string password)
        {
            string allowedSymbols = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%^*()/.";
            if (password.Length < 6 | password.Length > 32)
                return false;
            foreach (char ch in password)
                if (!allowedSymbols.Contains(ch))
                    return false;
            return true;
        }
    }
}
