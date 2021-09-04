using Squadra.Bootcamp.DesafioFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Squadra.Bootcamp.DesafioFinal.Repositories
{
    public class UserRepository
    {
        public static User Get(string username, string password)
        {
            var users = new List<User>();
            users.Add(new User { Id = 1, Username = "MATEMATICO", Password = "123456", Role = "MATEMATICO" });
            users.Add(new User { Id = 2, Username = "NAOMATEMATICO", Password = "123456", Role = "NAOMATEMATICO" });
            return users.Where(x => x.Username.ToLower() == username.ToLower() && x.Password == x.Password).FirstOrDefault();
        }
    }
}
