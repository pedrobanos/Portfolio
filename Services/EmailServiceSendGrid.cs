using Portfolio.Models;
using SendGrid;
using SendGrid.Helpers.Mail;

namespace Portfolio.Services
{
    public interface IServiceEmail
    {
        Task SendEmail(ContactViewModel contact);
    }
    public class EmailServiceSendGrid: IServiceEmail
    {
        private readonly IConfiguration configuration;

        public EmailServiceSendGrid(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public async Task SendEmail(ContactViewModel contact)
        {
            var apiKey = configuration.GetValue<string>("SENDGRID_API_KEY");
            var email = configuration.GetValue<string>("SENDGRID_FROM");
            var name = configuration.GetValue<string>("SENDGRID_NAME");

            var client = new SendGridClient(apiKey);
            var from = new EmailAddress(email, name);
            var subject = $"The recruiter {contact.Email} wants to get in touch with you";
            var to = new EmailAddress(email, name);
            var messageBodyEmail = contact.Message;
            var htmlContent = @$"De: {contact.Name}-
                Email: {contact.Email}
                 Message: {contact.Message}";
            var singleEmail = MailHelper.CreateSingleEmail(from, to, subject
                ,messageBodyEmail, htmlContent);

            var respond = await client.SendEmailAsync(singleEmail); 
        }
    }
}
