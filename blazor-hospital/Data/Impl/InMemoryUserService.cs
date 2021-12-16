using System;
using System.IO;
using System.Linq;
using blazor_hospital.Models;

namespace blazor_hospital.Data.Impl
{
    public class InMemoryUserService : IUserService
    {

        public User validateUser(string username, string password)
        {

            if (username == null)
            {
                throw new Exception("User not found");
            }
            
            if (password == null)
            {
                throw new Exception("Incorrect Password");
            }

            return null;
        }
    }
}   