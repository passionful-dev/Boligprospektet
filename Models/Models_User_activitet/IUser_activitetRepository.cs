using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Boligprospektet.Models.Models_User_activitet
{
  public interface IUser_activitetRepository
  {
    User_activitet GetUser_activitet(int id);
    IEnumerable<User_activitet> GetAllUser_activitets();
    User_activitet Create(User_activitet user_activitet);
    User_activitet Update(User_activitet user_activitetChanges);
    User_activitet Delete(int id);
  }
}
