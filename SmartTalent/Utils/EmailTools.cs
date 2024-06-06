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
                // Configuración del cliente SMTP
                SmtpClient client = new SmtpClient("smtp.mail.yahoo.com")
                {
                    Port = 587, // O el puerto correspondiente
                    Credentials = new NetworkCredential("judaleba@yahoo.com.ar", "{W6h58&}g'qm:>0k,6Ah"),
                    EnableSsl = true, // True si el servidor SMTP requiere SSL
                };

                // Creación del mensaje de correo
                MailMessage mailMessage = new MailMessage
                {
                    From = new MailAddress("leonjuandavid@hotmail.com"),
                    Subject = "Asunto del correo",
                    Body = "Contenido del correo" + _code,
                    IsBodyHtml = true, // True si el contenido es HTML
                };

                // Añadiendo destinatarios
                //mailMessage.To.Add("destinatario@dominio.com");
                // mailMessage.CC.Add("cc@dominio.com"); // Añadir si hay destinatarios en CC
                // mailMessage.Bcc.Add("bcc@dominio.com"); // Añadir si hay destinatarios en BCC

                // Enviando el correo
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
