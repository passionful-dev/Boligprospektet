using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Boligprospektet.Models.Models_User
{
  public interface IUserRepository
  {
    User GetUser(int id);
    IEnumerable<User> GetAllUsers();
    User Create(User user);
    User Update(User userChanges);
    User Delete(int id);
  }
}
