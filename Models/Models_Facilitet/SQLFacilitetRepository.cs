using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Boligprospektet.Models.Models_Facilitet
{
  public class SQLFacilitetRepository : IFacilitetRepository
  {
    private readonly AppDbContext context;

    public SQLFacilitetRepository(AppDbContext context)
    {
      this.context = context;
    }

    public Facilitet Create(Facilitet facilitet)
    {
      context.Facilitets.Add(facilitet);
      context.SaveChanges();
    	return facilitet;
    }

    public Facilitet Delete(int id)
    {
      Facilitet facilitet = context.Facilitets.Find(id);
      if(facilitet != null)
      {
        context.Facilitets.Remove(facilitet);
        context.SaveChanges();
      }
      return facilitet;
    }

    public IEnumerable<Facilitet> GetAllFacilitets()
    {
      return context.Facilitets;
    }

    public Facilitet GetFacilitet(int id)
    {
      return context.Facilitets.Find(id);
    }

    public Facilitet Update(Facilitet facilitetChanges)
    {
      var facilitet = context.Facilitets.Attach(facilitetChanges);
      facilitet.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
      context.SaveChanges();
      return facilitetChanges;
    }
  }
}
