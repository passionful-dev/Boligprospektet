using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Boligprospektet.Models.Models_Bolig_activitet
{
  public class SQLBolig_activitetRepository : IBolig_activitetRepository
  {
    private readonly AppDbContext context;

    public SQLBolig_activitetRepository(AppDbContext context)
    {
      this.context = context;
    }

    public Bolig_activitet Create(Bolig_activitet bolig_activitet)
    {
      context.Bolig_activitets.Add(bolig_activitet);
      context.SaveChanges();
    	return bolig_activitet;
    }

    public Bolig_activitet Delete(int id)
    {
      Bolig_activitet bolig_activitet = context.Bolig_activitets.Find(id);
      if(bolig_activitet != null)
      {
        context.Bolig_activitets.Remove(bolig_activitet);
        context.SaveChanges();
      }
      return bolig_activitet;
    }

    public IEnumerable<Bolig_activitet> GetAllBolig_activitets()
    {
      return context.Bolig_activitets;
    }

    public Bolig_activitet GetBolig_activitet(int id)
    {
      return context.Bolig_activitets.Find(id);
    }

    public Bolig_activitet Update(Bolig_activitet bolig_activitetChanges)
    {
      var bolig_activitet = context.Bolig_activitets.Attach(bolig_activitetChanges);
      bolig_activitet.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
      context.SaveChanges();
      return bolig_activitetChanges;
    }
  }
}
