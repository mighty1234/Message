using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using Application.Data;

namespace Application.Service.Services
{
 public   interface IMessageService
    {
        List<Message> GetMessage();
        Message GetMessageById(Guid id);
        Guid SaveMessage(Message mess);



    }
}
