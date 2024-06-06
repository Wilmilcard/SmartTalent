using System.Net.Mail;
using System.Net;

namespace SmartTalent.Utils
{
    public class EmailTools
    {
        public static bool SendEmails(string _email, string _code)
        {
            try
            {
                SmtpClient client = new SmtpClient("smtp.mail.yahoo.com")
                {
                    Port = 587, 
                    Credentials = new NetworkCredential("el correo enviante", "contraseña"),
                    EnableSsl = true, 
                };

                MailMessage mailMessage = new MailMessage
                {
                    From = new MailAddress("el correo que recibe"),
                    Subject = "Asunto del correo",
                    Body = "Contenido del correo" + _code,
                    IsBodyHtml = true, // True si el contenido es HTML
                };

                // mailMessage.To.Add("destinatario@dominio.com");
                // mailMessage.CC.Add("cc@dominio.com"); 
                // mailMessage.Bcc.Add("bcc@dominio.com");

                client.Send(mailMessage);
                Console.WriteLine("Correo enviado exitosamente.");
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al enviar el correo: " + ex.Message);
                return false;
            }
        }
    }
}
