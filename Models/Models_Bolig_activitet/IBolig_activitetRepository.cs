using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Boligprospektet.Models.Models_Bolig_activitet
{
  public interface IBolig_activitetRepository
  {
    Bolig_activitet GetBolig_activitet(int id);
    IEnumerable<Bolig_activitet> GetAllBolig_activitets();
    Bolig_activitet Create(Bolig_activitet bolig_activitet);
    Bolig_activitet Update(Bolig_activitet bolig_activitetChanges);
    Bolig_activitet Delete(int id);
  }
}
