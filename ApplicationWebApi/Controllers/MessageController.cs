using Application.Data;
using Application.Service.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Description;


namespace ApplicationWebApi.Controllers
{
    public class MessageController : ApiController
    {
        private IMessageService messageService = new MessageService();

        [ResponseType(typeof(Message))]
        //[Route("api/message/getall")]
        [HttpGet]
        public IEnumerable<Message> GetAll()
        {
            return messageService.GetMessage();
        }
        //[EnableCors(origins: "*", headers: "*", methods: "*")]
        //[ResponseType(typeof(Guid))]
        //[Route("api/message/save")]
        [HttpPost]
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
