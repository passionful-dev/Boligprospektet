using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Boligprospektet.Models.Models_User
{
  public class User
  {
    [Key]
    public int User_Id { get; set; }
    public string Date_Time { get; set; }
    public string Fuldnavn { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public int Mobile { get; set; }
    public string User_Type { get; set; }
  }
}
