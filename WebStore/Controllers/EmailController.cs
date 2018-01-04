using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ActionMailer.Net.Mvc;
using WebStore.Services.DTO;

namespace WebStore.Controllers
{
    public class EmailController : MailerBase
    {
        // GET: Email
        public EmailResult SendEmail(EmailModel model)
        {
			To.Add( "ieroglif.kerch@gmail.com" );
			From = "webstore@mail.com";
			Subject = model.Subject;
			return Email( "SendEmail", model );
        }
    }
}