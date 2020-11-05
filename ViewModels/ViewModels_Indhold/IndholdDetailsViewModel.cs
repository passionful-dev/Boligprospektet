using Boligprospektet.Models.Models_Indhold;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Boligprospektet.ViewModels.ViewModels_Indhold
{
    public class IndholdDetailsViewModel
    {
        public Indhold Indhold { get; set; }
        public string PageTitle { get; set; }
    }
}
