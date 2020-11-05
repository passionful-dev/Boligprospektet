using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Boligprospektet.Models.Models_Bolig_type_activitet
{
  public interface IBolig_type_activitetRepository
  {
    Bolig_type_activitet GetBolig_type_activitet(int id);
    IEnumerable<Bolig_type_activitet> GetAllBolig_type_activitets();
    Bolig_type_activitet Create(Bolig_type_activitet bolig_type_activitet);
    Bolig_type_activitet Update(Bolig_type_activitet bolig_type_activitetChanges);
    Bolig_type_activitet Delete(int id);
  }
}
