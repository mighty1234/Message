using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Application.Data;
using System.Data;
using System.Web.Helpers;
using System.Data.Entity;

namespace Application.Service.Services
{
    public class LogService : ILogService
    {
      

       
  
        public List<Log> GetLog()
       {
          
                SoftPiEntities softPi = new SoftPiEntities();
            using (var context = new SoftPiEntities())
            {
                context.Configuration.ProxyCreationEnabled = false;
                var response = context.Log.Include(u => u.IP).Include(q => q.File).AsNoTracking();
                return response.ToList();
            }
           
          
            
        }       

        

        

        
    }
}