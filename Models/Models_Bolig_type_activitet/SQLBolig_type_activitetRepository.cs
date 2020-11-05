using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Boligprospektet.Models.Models_Bolig_type_activitet
{
  public class SQLBolig_type_activitetRepository : IBolig_type_activitetRepository
  {
    private readonly AppDbContext context;

    public SQLBolig_type_activitetRepository(AppDbContext context)
    {
      this.context = context;
    }

    public Bolig_type_activitet Create(Bolig_type_activitet bolig_type_activitet)
    {
      context.Bolig_type_activitets.Add(bolig_type_activitet);
      context.SaveChanges();
    	return bolig_type_activitet;
    }

    public Bolig_type_activitet Delete(int id)
    {
      Bolig_type_activitet bolig_type_activitet = context.Bolig_type_activitets.Find(id);
      if(bolig_type_activitet != null)
      {
        context.Bolig_type_activitets.Remove(bolig_type_activitet);
        context.SaveChanges();
      }
      return bolig_type_activitet;
    }

    public IEnumerable<Bolig_type_activitet> GetAllBolig_type_activitets()
    {
      return context.Bolig_type_activitets;
    }

    public Bolig_type_activitet GetBolig_type_activitet(int id)
    {
      return context.Bolig_type_activitets.Find(id);
    }

    public Bolig_type_activitet Update(Bolig_type_activitet bolig_type_activitetChanges)
    {
      var bolig_type_activitet = context.Bolig_type_activitets.Attach(bolig_type_activitetChanges);
      bolig_type_activitet.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
      context.SaveChanges();
      return bolig_type_activitetChanges;
    }
  }
}
