using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Boligprospektet.Models.Models_Facilitet
{
  public interface IFacilitetRepository
  {
    Facilitet GetFacilitet(int id);
    IEnumerable<Facilitet> GetAllFacilitets();
    Facilitet Create(Facilitet facilitet);
    Facilitet Update(Facilitet facilitetChanges);
    Facilitet Delete(int id);
  }
}
