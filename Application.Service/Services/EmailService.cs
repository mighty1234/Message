using Application.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Mail;
using System.Net;

namespace Application.Service.Services
{
    public  static class EmailService
    {
        public static bool SendEmail(Message mes )
        {
             var recipients =mes.Recipients.Split(' ');

            try
            {
                foreach (var resipient in recipients)
                {

                    // отправитель - устанавливаем адрес и отображаемое в письме имя
                    MailAddress from = new MailAddress("Vladlegenda97@gmail.com", "Vladislav");
                    // кому отправляем
                    MailAddress to = new MailAddress(resipient);
                    // создаем объект сообщения
                    MailMessage m = new MailMessage(from, to);
                    // тема письма
                    m.Subject = mes.Subject;
                    // текст письма
                    m.Body = "<h2>" + mes.Body + "</h2>";
                    // письмо представляет код html
                    m.IsBodyHtml = true;
                    // адрес smtp-сервера и порт, с которого будем отправлять письмо
                    SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                    // логин и пароль
                    smtp.Credentials = new NetworkCredential("Vladlegenda97@gmail.com", "DickHead");
                    smtp.EnableSsl = false;
                    smtp.Send(m);
                  
                }
                return true;
            }
            catch(Exception)
            {
                return false;
            }

           
        }
    }
    }
