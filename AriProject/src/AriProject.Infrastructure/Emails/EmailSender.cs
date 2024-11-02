using System.Threading.Tasks;
using AriProject.Application.Configuration.Emails;

namespace AriProject.Infrastructure.Emails
{
    public class EmailSender : IEmailSender
    {
        public async Task SendEmailAsync(EmailMessage message)
        {
            // Integration with email service.

            return;
        }
    }
}