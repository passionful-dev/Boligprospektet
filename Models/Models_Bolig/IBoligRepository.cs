using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Boligprospektet.Models.Models_Bolig
{
  public interface IBoligRepository
  {
    Bolig GetBolig(int id);
    IEnumerable<Bolig> GetAllBoligs();
    Bolig Create(Bolig bolig);
    Bolig Update(Bolig boligChanges);
    Bolig Delete(int id);
  }
}
