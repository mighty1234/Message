using Application.Data;
using Application.Service.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace ApplicationWebApi.Controllers
{
    public class MessageController : ApiController
    {
        private IMessageService messageService = new MessageService();

        [ResponseType(typeof(Message))]
        [Route("api/message/getall")]
        public IEnumerable<Message> GetAll()
        {
            return messageService.GetMessage();
        }

        [ResponseType(typeof(Guid))]
        [Route("api/message/save")]
        public IHttpActionResult SaveMessage(Message mes)
        {
            try
            {
             return Ok( messageService.SaveMessage(mes));
                
            }
            catch (Exception)
            {
             return StatusCode(HttpStatusCode.BadRequest);
            }
        }
    }
}
