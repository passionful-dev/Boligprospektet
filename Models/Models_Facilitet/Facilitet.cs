using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Boligprospektet.Models.Models_Facilitet
{
  public class Facilitet
  {
    [Key]
    public int Facilitet_Id { get; set; }
    public int Bolig_Id { get; set; }
    public string Faciliteter { get; set; }
    public string Facilitet_Beskrivelser { get; set; }
  }
}
