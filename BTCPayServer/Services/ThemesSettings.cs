using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BTCPayServer.Services
{
    public class ThemeSettings
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Populate)]
        [MaxLength(500)]
        [Display(Name = "Archivo CSS bootstrap personalizado")]
        public string BootstrapCssUri { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Populate)]
        public string CreativeStartCssUri { get; set; }
    }
}
