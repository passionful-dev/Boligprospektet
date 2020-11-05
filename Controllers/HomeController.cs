using Boligprospektet.Models.Models_Bolig;
using Boligprospektet.Models.Models_Bolig_type;
using Boligprospektet.Models.Models_Facilitet;
using Boligprospektet.Models.Models_Indhold;
using Boligprospektet.Models.Models_User;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Boligprospektet.Controllers
{
    [Route("[controller]/[action]")]
    public class HomeController : Controller
    {
        private readonly IUserRepository _userRepository;
        private readonly IBoligRepository _boligRepository;
        private readonly IBolig_typeRepository _bolig_TypeRepository;
        private readonly IFacilitetRepository _facilitetRepository;
        private readonly IIndholdRepository _indholdRepository;

        public HomeController(IUserRepository userRepository, IBoligRepository boligRepository,
            IBolig_typeRepository bolig_TypeRepository, IFacilitetRepository facilitetRepository,
            IIndholdRepository indholdRepository)
        {
            _userRepository = userRepository;
            _boligRepository = boligRepository;
            _bolig_TypeRepository = bolig_TypeRepository;
            _facilitetRepository = facilitetRepository;
            _indholdRepository = indholdRepository;
        }


    }
}
