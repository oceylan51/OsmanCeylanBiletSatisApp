using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CeylanTurizm.WebUI.EmailSender
{
    public interface IEmailSender
    {
        Task SendEmailSenderAsync(string email, string subject, string htmlMessage);
    }
}
