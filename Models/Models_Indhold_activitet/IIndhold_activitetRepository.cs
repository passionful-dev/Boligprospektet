using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Boligprospektet.Models.Models_Indhold_activitet
{
  public interface IIndhold_activitetRepository
  {
    Indhold_activitet GetIndhold_activitet(int id);
    IEnumerable<Indhold_activitet> GetAllIndhold_activitets();
    Indhold_activitet Create(Indhold_activitet indhold_activitet);
    Indhold_activitet Update(Indhold_activitet indhold_activitetChanges);
    Indhold_activitet Delete(int id);
  }
}
