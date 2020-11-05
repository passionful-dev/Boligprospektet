using Boligprospektet.Models.Models_User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Boligprospektet.ViewModels.ViewModels_User
{
    public class UserDetailsViewModel
    {
        public User User { get; set; }
        public string PageTitle { get; set; }
    }
}
