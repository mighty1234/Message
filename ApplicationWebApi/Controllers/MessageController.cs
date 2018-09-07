using Application.Data;
using Application.Service.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;


namespace ApplicationWebApi.Controllers
{
    public class MessageController : ApiController
    {
        private IMessageService messageService = new MessageService();

        [Route("api/message/getall")]
        public IEnumerable<Message> GetAll()
        {
            return messageService.GetMessage();
        }
        //[Route("api/message/Save")]
        //public bool SaveMessage(Message mes)
        //{

        //}
    }
}
