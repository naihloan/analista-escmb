using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ManuelBelgrano.WebAppService.Controllers
{
    //https://localhost:44313/api/Autenticar
    [Route("api/Autenticar")]
    [ApiController]
    public class AutenticacionController : ControllerBase
    {

        [HttpGet]
        public bool Login(string email, string password)
        {
            return true;
        }

    }
      

}
