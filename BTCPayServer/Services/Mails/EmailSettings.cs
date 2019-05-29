using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace BTCPayServer.Services.Mails
{
    public class EmailSettings
    {
        [Display(Name = "Servidor")]
        public string Server
        {
            get; set;
        }

        [Display(Name = "Puerto")]
        public int? Port
        {
            get; set;
        }

        [Display(Name = "Usuario")]
        public string Login
        {
            get; set;
        }

        [Display(Name = "Contraseña")]
        [DataType(DataType.Password)]
        public string Password
        {
            get; set;
        }

        [Display(Name = "Desde")]
        [EmailAddress]
        public string From
        {
            get; set;
        }

        [Display(Name = "Habilitar SSL")]
        public bool EnableSSL
        {
            get; set;
        }

        public bool IsComplete()
        {
            SmtpClient smtp = null;
            try
            {
                smtp = CreateSmtpClient();
                return true;
            }
            catch { }
            return false;
        }

        public SmtpClient CreateSmtpClient()
        {
            SmtpClient client = new SmtpClient(Server, Port.Value);
            client.EnableSsl = EnableSSL;
            client.UseDefaultCredentials = false;
            client.Credentials = new NetworkCredential(Login, Password);
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.Timeout = 10000;
            return client;
        }
    }
}
