using Boligprospektet.Models.Models_Bolig;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Boligprospektet.ViewModels.ViewModels_Bolig
{
    public class BoligDetailsViewModel
    {
        public Bolig Bolig { get; set; }
        public string PageTitle { get; set; }
    }
}
