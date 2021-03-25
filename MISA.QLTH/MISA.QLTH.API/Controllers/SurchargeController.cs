using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MISA.QLTH.ApplicationCore.Entity;
using MISA.QLTH.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MISA.QLTH.API.Controllers
{
    
    public class SurchargeController : BaseController<Surcharge>
    {
        public SurchargeController(IBaseService<Surcharge> baseService) :base(baseService)
        {

        }
    }
}
