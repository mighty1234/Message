using Application.Data;
using Application.Service.Services;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Description;


namespace ApplicationWebApi.Controllers
{
    public class LogController : ApiController
    {
        private LogService logService = new LogService();

       
        
        [HttpGet]
        public  List<Log> GetAll()
        {                       
            return logService.GetLog(); ;
        }
       
    }
}
