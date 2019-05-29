using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using BTCPayServer.Payments;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BTCPayServer.Models.StoreViewModels
{
    public class UpdateChangellySettingsViewModel
    {
        [Required] public string ApiKey { get; set; }

        [Required] public string ApiSecret { get; set; }

        [Required] public string ApiUrl { get; set; } = "https://api.changelly.com";

        [Display(Name = "Opcional, Id. changelly comerciante")]
        public string ChangellyMerchantId { get; set; }

        [Display(Name = "Mostrar monedas Fiat como opción en conversión.")]
        public bool ShowFiat { get; set; } = true;

        [Required]
        [Range(0, 100)]
        [Display(Name =
            "Porcentaje para multiplicar la cantidad solicitada en Changelly para evitar situaciones mal pagadas debido a que Changelly no garantiza las tasas. ")]
        public decimal AmountMarkupPercentage { get; set; } = new decimal(2);

        public bool Enabled { get; set; }

        public string StatusMessage { get; set; }
    }
}
