using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using BTCPayServer.Configuration;
using BTCPayServer.SSH;
using Renci.SshNet;

namespace BTCPayServer.Models.ServerViewModels
{
    public class MaintenanceViewModel
    {
        public bool ExposedSSH { get; set; }

        [Display(Name = "Nombre de usuario")]
        [Required]
        public string UserName { get; set; }

        [Display(Name = "Contraseña")]
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        
        [Display(Name = "Cambiar dominio")]
        public string DNSDomain { get; set; }
        public SshClient CreateSSHClient(string host)
        {
            return new SshClient(host, UserName, Password);
        }

        internal void SetConfiguredSSH(SSHSettings settings)
        {
            if(settings != null)
            {
                ExposedSSH = true;
                UserName = "desconocido";
                Password = "desconocido";
            }
        }
    }
}
