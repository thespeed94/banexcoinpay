using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using BTCPayServer.Payments.CoinSwitch;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BTCPayServer.Models.StoreViewModels
{
    public class UpdateCoinSwitchSettingsViewModel
    {
        public string MerchantId { get; set; }
        public bool Enabled { get; set; }

        [Display(Name = "Modo de integración")]
        public string Mode { get; set; } = "inline";
        
        [Required]
        [Range(0, 100)]
        [Display(Name =
            "Porcentaje para multiplicar la cantidad solicitada en Coinswitch para evitar situaciones de pago insuficiente debido a que Coinswitch no garantiza las tasas. ")]
        public decimal AmountMarkupPercentage { get; set; } = new decimal(2);

        public List<SelectListItem> Modes { get; } = new List<SelectListItem>
        {
            new SelectListItem { Value = "popup", Text = "Abrir en una ventana emergente" },
            new SelectListItem { Value = "inline", Text = "Incrustar dentro de la interfaz de usuario de pago " },
        };
        
        public string StatusMessage { get; set; }
    }
}
