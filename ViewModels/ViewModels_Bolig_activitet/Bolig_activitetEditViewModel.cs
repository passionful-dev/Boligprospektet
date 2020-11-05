using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Boligprospektet.ViewModels.ViewModels_Bolig_activitet
{
    public class Bolig_activitetEditViewModel
    {
        public int Bolig_activitet_Id { get; set; }
        public string Date_Time { get; set; }
        public int User_Id { get; set; }
        public int Bolig_Id { get; set; }
        public string Bolig_Navn { get; set; }
        public string Bolig_activitet_Navn { get; set; }
    }
}
