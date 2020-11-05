using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Boligprospektet.Models.Models_Indhold
{
  public interface IIndholdRepository
  {
    Indhold GetIndhold(int id);
    IEnumerable<Indhold> GetAllIndholds();
    Indhold Create(Indhold indhold);
    Indhold Update(Indhold indholdChanges);
    Indhold Delete(int id);
  }
}
