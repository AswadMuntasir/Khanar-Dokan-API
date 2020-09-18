using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Khanar_Dokan_API.Controllers
{
    [RoutePrefix("manager")]
    public class ManagerController : ApiController
    {
    	UserRepository userRepo = new UserRepository();

        [Route("")]
        //[BasicAuthorization]
        public IHttpActionResult Get()
        {
            return Ok(userRepo.GetAll());
        }

    }
}
