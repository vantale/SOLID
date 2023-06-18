using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.BadCode.GodMethod
{
    internal class GodMethodClass
    {
        public void SrpBrokenMethod(string folder, string filename, string text,
string emailFrom, string password, string emailTo, string subject, string message, string mediaType)
        {
            var file = $"{folder}{filename}";
            File.WriteAllText(file, text);
            MailMessage message = new MailMessage();
            SmtpClient smtp = new SmtpClient();
            message.From = new MailAddress(emailFrom);
            message.To.Add(new MailAddress(emailTo));
            message.Subject = subject;
            message.IsBodyHtml = true;
            message.Body = message;
            Attachment emailAttachment = new Attachment(file);
            emailAttachment.ContentDisposition.Inline = false;
            emailAttachment.ContentDisposition.DispositionType =
            DispositionTypeNames.Attachment;
            emailAttachment.ContentType.MediaType = mediaType;
            emailAttachment.ContentType.Name = Path.GetFileName(filename);
            message.Attachments.Add(emailAttachment);
            smtp.Port = 587;
            smtp.Host = "smtp.gmail.com";
            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential(emailFrom, password);
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Send(message);

        }
    }
