using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Boligprospektet.Models.Models_Indhold
{
  public class SQLIndholdRepository : IIndholdRepository
  {
    private readonly AppDbContext context;

    public SQLIndholdRepository(AppDbContext context)
    {
      this.context = context;
    }

    public Indhold Create(Indhold indhold)
    {
      context.Indholds.Add(indhold);
      context.SaveChanges();
    	return indhold;
    }

    public Indhold Delete(int id)
    {
      Indhold indhold = context.Indholds.Find(id);
      if(indhold != null)
      {
        context.Indholds.Remove(indhold);
        context.SaveChanges();
      }
      return indhold;
    }

    public IEnumerable<Indhold> GetAllIndholds()
    {
      return context.Indholds;
    }

    public Indhold GetIndhold(int id)
    {
      return context.Indholds.Find(id);
    }

    public Indhold Update(Indhold indholdChanges)
    {
      var indhold = context.Indholds.Attach(indholdChanges);
      indhold.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
      context.SaveChanges();
      return indholdChanges;
    }
  }
}
