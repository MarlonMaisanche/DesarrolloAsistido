using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace AdmiTienda
{
    public static class Utilidad
    {
        public static string EnviarEmail(string destinatario, string asunto, string mensaje)
        { 
            string emisor = "daps_tiendavirtual@outlook.com";
            string nombre = "Tienda-Virutal DAPS";
            try
            {
                MailMessage correo = new MailMessage();
                correo.From =  new MailAddress(emisor, nombre);
                correo.To.Add(destinatario);
                correo.Subject = asunto;
                correo.Body = mensaje;
                correo.IsBodyHtml = true;

                SmtpClient cliente = new SmtpClient("smtp.office365.com", 587);
                cliente.Credentials = new NetworkCredential(emisor, "daps_123456");
                cliente.EnableSsl = true;
                cliente.Send(correo);
                return "Notificado exitosamente al cliente por medio de correo electrónico";
            }
            catch(Exception e)
            {
                return e.Message + " - No se pudo notificar al cliente por medio de correo electrónico. Notificarlo por otros medios";
            }
        }
    }
}
