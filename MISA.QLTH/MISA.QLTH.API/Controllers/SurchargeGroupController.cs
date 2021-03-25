using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MISA.QLTH.ApplicationCore.Entities;
using MISA.QLTH.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MISA.QLTH.API.Controllers
{

    public class SurchargeGroupController : BaseController<SurchargeGroup>
    {
        public SurchargeGroupController(IBaseService<SurchargeGroup> baseService) : base(baseService)
        {

        }
    }
}
