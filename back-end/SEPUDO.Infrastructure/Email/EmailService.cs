using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using SendGrid;
using SendGrid.Helpers.Mail;
using SEPUDO.Application.Contracts.Infrastructure;
using SEPUDO.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEPUDO.Infrastructure.Email
{
    public class EmailService : IEmailService
    {
        public EmailSettings emailSettings { get; }

        public ILogger<EmailService> logger { get;}

        public EmailService(IOptions<EmailSettings> emailSettings, ILogger<EmailService> logger)
        {
            this.emailSettings = emailSettings.Value;
            this.logger = logger;
        }

        public async Task<bool> SendEmail(Application.Models.Email email)
        {
            var client = new SendGridClient(emailSettings.ApiKey);

            var subject = email.Subject;
            var to = new EmailAddress(email.To);
            var emailBody = email.Body;
            var from = new EmailAddress
            {
                Email = emailSettings.FromAddress,
                Name = emailSettings.FromName
            };

            var sendGridMessage = MailHelper.CreateSingleEmail(from, to, subject, emailBody, emailBody);
            var response =await client.SendEmailAsync(sendGridMessage);

            if (response.StatusCode==System.Net.HttpStatusCode.Accepted || response.StatusCode==System.Net.HttpStatusCode.OK)
            {
                return true;
            }

            logger.LogError("El email no pudo enviarse, existen errores");
            return false;
        }

       
    }
}
