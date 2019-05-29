using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using BTCPayServer.Services.Rates;

namespace BTCPayServer.Models.ServerViewModels
{
    public class RatesViewModel
    {
        [Display(Name = "Bitcoin teclas de api promedio")]
        public string PublicKey { get; set; }
        public string PrivateKey { get; set; }
        [Display(Name = "Guarda en caché las tarifas por ... minutos")]
        [Range(0, 60)]
        public int CacheMinutes { get; set; }
        public GetRateLimitsResponse RateLimits { get; internal set; }
    }
}
