using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Boligprospektet.ViewModels.ViewModels_User_activitet
{
    public class User_activitetCreateViewModel
    {
        public int User_activitet_Id { get; set; }
        public string Date_Time { get; set; }
        public int User_Id { get; set; }
        public string Fuldnavn { get; set; }
        public string User_activitet_Navn { get; set; }
    }
}
