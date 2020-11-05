using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Boligprospektet.ViewModels.ViewModels_Bolig_type_activitet
{
    public class Bolig_type_activitetCreateViewModel
    {
        public int Bolig_type_activitet_Id { get; set; }
        public string Date_Time { get; set; }
        public int User_Id { get; set; }
        public int Bolig_type_Id { get; set; }
        public string Bolig_type_Navn { get; set; }
        public string Bolig_type_activitet_Navn { get; set; }
    }
}
