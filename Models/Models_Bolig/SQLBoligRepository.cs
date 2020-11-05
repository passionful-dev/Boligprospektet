using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Boligprospektet.Models.Models_Bolig
{
  public class SQLBoligRepository : IBoligRepository
  {
    private readonly AppDbContext context;

    public SQLBoligRepository(AppDbContext context)
    {
      this.context = context;
    }

    public Bolig Create(Bolig bolig)
    {
      context.Boligs.Add(bolig);
      context.SaveChanges();
    	return bolig;
    }

    public Bolig Delete(int id)
    {
      Bolig bolig = context.Boligs.Find(id);
      if(bolig != null)
      {
        context.Boligs.Remove(bolig);
        context.SaveChanges();
      }
      return bolig;
    }

    public IEnumerable<Bolig> GetAllBoligs()
    {
      return context.Boligs;
    }

    public Bolig GetBolig(int id)
    {
      return context.Boligs.Find(id);
    }

    public Bolig Update(Bolig boligChanges)
    {
      var bolig = context.Boligs.Attach(boligChanges);
      bolig.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
      context.SaveChanges();
      return boligChanges;
    }
  }
}
