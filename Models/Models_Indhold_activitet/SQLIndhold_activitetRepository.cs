using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Boligprospektet.Models.Models_Indhold_activitet
{
  public class SQLIndhold_activitetRepository : IIndhold_activitetRepository
  {
    private readonly AppDbContext context;

    public SQLIndhold_activitetRepository(AppDbContext context)
    {
      this.context = context;
    }

    public Indhold_activitet Create(Indhold_activitet indhold_activitet)
    {
      context.Indhold_activitets.Add(indhold_activitet);
      context.SaveChanges();
    	return indhold_activitet;
    }

    public Indhold_activitet Delete(int id)
    {
      Indhold_activitet indhold_activitet = context.Indhold_activitets.Find(id);
      if(indhold_activitet != null)
      {
        context.Indhold_activitets.Remove(indhold_activitet);
        context.SaveChanges();
      }
      return indhold_activitet;
    }

    public IEnumerable<Indhold_activitet> GetAllIndhold_activitets()
    {
      return context.Indhold_activitets;
    }

    public Indhold_activitet GetIndhold_activitet(int id)
    {
      return context.Indhold_activitets.Find(id);
    }

    public Indhold_activitet Update(Indhold_activitet indhold_activitetChanges)
    {
      var indhold_activitet = context.Indhold_activitets.Attach(indhold_activitetChanges);
      indhold_activitet.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
      context.SaveChanges();
      return indhold_activitetChanges;
    }
  }
}
