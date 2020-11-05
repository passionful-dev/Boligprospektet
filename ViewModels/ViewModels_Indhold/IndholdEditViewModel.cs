using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Boligprospektet.ViewModels.ViewModels_Indhold
{
    public class IndholdEditViewModel
    {
        public int Indhold_Id { get; set; }
        public string Date_Time { get; set; }
        public int User_Id { get; set; }
        public string Indhold_Navn { get; set; }
        public string Indhold_Beskrivelser { get; set; }
    }
}
