using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Boligprospektet.Models.Models_Bolig_type
{
  public class SQLBolig_typeRepository : IBolig_typeRepository
  {
    private readonly AppDbContext context;

    public SQLBolig_typeRepository(AppDbContext context)
    {
      this.context = context;
    }

    public Bolig_type Create(Bolig_type bolig_type)
    {
      context.Bolig_types.Add(bolig_type);
      context.SaveChanges();
    	return bolig_type;
    }

    public Bolig_type Delete(int id)
    {
      Bolig_type bolig_type = context.Bolig_types.Find(id);
      if(bolig_type != null)
      {
        context.Bolig_types.Remove(bolig_type);
        context.SaveChanges();
      }
      return bolig_type;
    }

    public IEnumerable<Bolig_type> GetAllBolig_types()
    {
      return context.Bolig_types;
    }

    public Bolig_type GetBolig_type(int id)
    {
      return context.Bolig_types.Find(id);
    }

    public Bolig_type Update(Bolig_type bolig_typeChanges)
    {
      var bolig_type = context.Bolig_types.Attach(bolig_typeChanges);
      bolig_type.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
      context.SaveChanges();
      return bolig_typeChanges;
    }
  }
}
