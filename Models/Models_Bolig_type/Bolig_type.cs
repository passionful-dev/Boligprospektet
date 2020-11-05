using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Boligprospektet.Models.Models_Bolig_type
{
  public class Bolig_type
  {
    [Key]
    public int Bolig_type_Id { get; set; }
    public string Date_Time { get; set; }
    public int User_Id { get; set; }
    public string Bolig_type_Navn { get; set; }
  }
}
