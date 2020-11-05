using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Boligprospektet.Models.Models_Bolig_type
{
  public interface IBolig_typeRepository
  {
    Bolig_type GetBolig_type(int id);
    IEnumerable<Bolig_type> GetAllBolig_types();
    Bolig_type Create(Bolig_type bolig_type);
    Bolig_type Update(Bolig_type bolig_typeChanges);
    Bolig_type Delete(int id);
  }
}
