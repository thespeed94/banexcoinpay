using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using BTCPayServer.Services.Apps;
using Newtonsoft.Json;

namespace BTCPayServer.Services
{
    public class PoliciesSettings
    {
        [Display(Name = "Requiere un correo de confirmación para registrarse.")]
        public bool RequiresConfirmedEmail { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Populate)]
        [Display(Name = "Deshabilitar registro")]
        public bool LockSubscription { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Populate)]
        [Display(Name = "Desalentar a los motores de búsqueda de indexar este sitio.")]
        public bool DiscourageSearchEngines { get; set; }

        [Display(Name = "Mostrar la aplicación en la raíz del sitio web")]
        public string RootAppId { get; set; }

        public AppType? RootAppType { get; set; }
    }
}
