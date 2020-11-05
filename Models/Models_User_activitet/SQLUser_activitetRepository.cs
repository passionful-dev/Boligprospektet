using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Boligprospektet.Models.Models_User_activitet
{
  public class SQLUser_activitetRepository : IUser_activitetRepository
  {
    private readonly AppDbContext context;

    public SQLUser_activitetRepository(AppDbContext context)
    {
      this.context = context;
    }

    public User_activitet Create(User_activitet user_activitet)
    {
      context.User_activitets.Add(user_activitet);
      context.SaveChanges();
    	return user_activitet;
    }

    public User_activitet Delete(int id)
    {
      User_activitet user_activitet = context.User_activitets.Find(id);
      if(user_activitet != null)
      {
        context.User_activitets.Remove(user_activitet);
        context.SaveChanges();
      }
      return user_activitet;
    }

    public IEnumerable<User_activitet> GetAllUser_activitets()
    {
      return context.User_activitets;
    }

    public User_activitet GetUser_activitet(int id)
    {
      return context.User_activitets.Find(id);
    }

    public User_activitet Update(User_activitet user_activitetChanges)
    {
      var user_activitet = context.User_activitets.Attach(user_activitetChanges);
      user_activitet.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
      context.SaveChanges();
      return user_activitetChanges;
    }
  }
}
