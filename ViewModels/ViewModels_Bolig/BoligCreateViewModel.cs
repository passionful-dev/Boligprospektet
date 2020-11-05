using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Boligprospektet.ViewModels.ViewModels_Bolig
{
    public class BoligCreateViewModel
    {
        public int Bolig_Id { get; set; }
        public string Date_Time { get; set; }
        public int User_Id { get; set; }
        public int Type_Id { get; set; }
        public string Adresse_Vej { get; set; }
        public string Adresse_Postnr { get; set; }
        public int Adresse_Code { get; set; }
        public string Adresse_By { get; set; }
        public int Leje_kr { get; set; }
        public int Deposit_kr { get; set; }
        public int Areal_msquare { get; set; }
        public int Antal_Værelser { get; set; }
        public string Bolig_Beskrivelser { get; set; }
        public string Bolig_Navn { get; set; }
        public string Photos { get; set; }
        public string Ledig_Fra { get; set; }
        public string Annonse_Til { get; set; }
    }
}
