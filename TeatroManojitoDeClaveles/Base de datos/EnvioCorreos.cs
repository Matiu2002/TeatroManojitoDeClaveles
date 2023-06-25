using System.Net;
using System.Net.Mail;

namespace WPFPublicidad.Clases
{
    internal class EnvioCorreos
    {
        private bool EnviarCorreo(string destino, string asunto, string cuerpo)
        {
            string from = "publicidadhyh@outlook.com";
            string displayName = "Publicidad H&H";
            bool ok;
            try
            {
                MailMessage mail = new MailMessage
                {
                    From = new MailAddress(from, displayName),
                    Subject = asunto,
                    Body = cuerpo,
                    IsBodyHtml = true
                };
                mail.To.Add(destino);

                SmtpClient smtp = new SmtpClient("smtp.office365.com", 587);
                
                smtp.Credentials = new NetworkCredential(from, "puhyh123");
                smtp.EnableSsl = true;

                smtp.Send(mail);
                ok = true;
            }
            catch
            {
                ok = false;
            }
            return ok;
        }
        public bool RecuperarContraseña(string correo, string codigo)
        {
            string cuerpo = "Su código de recuperación es " + codigo + ". Ingreselo en la aplicación para continuar con la recuperación.";
            return EnviarCorreo(correo, "Recuperación de cuenta", cuerpo);
        }
        public bool Registro(string correo, string codigo)
        {
            string cuerpo = "Su código de registro es " + codigo + ". Ingreselo en la aplicación para continuar.";
            return EnviarCorreo(correo, "Registro", cuerpo);
        }
    }
}
