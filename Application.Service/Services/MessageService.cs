using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Application.Data;
using System.Data;

namespace Application.Service.Services
{
    public class MessageService : IMessageService
    {
        private MessageEntity db = new MessageEntity();
        public List<Message> GetMessage()
        {
            return db.Message.ToList();
        }

        public Message GetMessageById(Guid id)
        {
            // return db.Message.Where(x=>x.guid==id);
            return null;
        }

        public Guid SaveMessage(Message mess)
        {
          var x=  EmailService.SendEmail(mess);
            mess.IsSent = (!x) ? false : true;          
              
            db.Message.Add(mess);
            db.SaveChanges();
            return mess.guid;
        }

        
    }
}