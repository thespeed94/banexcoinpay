using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using BTCPayServer.Payments;
using BTCPayServer.Services;
using BTCPayServer.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BTCPayServer.Models.StoreViewModels
{
    public class CheckoutExperienceViewModel
    {
        public class Format
        {
            public string Name { get; set; }
            public string Value { get; set; }
            public PaymentMethodId PaymentId { get; set; }
        }
        public SelectList CryptoCurrencies { get; set; }
        public SelectList Languages { get; set; }

        [Display(Name = "Método de pago predeterminado en el pago y envío")]
        public string DefaultPaymentMethod { get; set; }
        [Display(Name = "Idioma por defecto al finalizar la compra")]
        public string DefaultLang { get; set; }

        [Display(Name = "Enlace a una hoja de estilo CSS personalizada")]
        [Uri]
        public string CustomCSS { get; set; }
        [Display(Name = "Enlace a un logotipo personalizado")]
        [Uri]
        public string CustomLogo { get; set; }

        [Display(Name = "Título HTML personalizado para mostrar en la página de pago")]
        public string HtmlTitle { get; set; }

        [Display(Name = "Requiere un email de reembolso")]
        public bool RequiresRefundEmail { get; set; }

        [Display(Name = "No proponga el pago en cadena si el valor de la factura es inferior a ...")]
        [MaxLength(20)]
        public string OnChainMinValue { get; set; }

        [Display(Name = "No proponga el pago con Lightning si el valor de la factura está por encima de ...")]
        [MaxLength(20)]
        public string LightningMaxValue { get; set; }

        [Display(Name = "Mostrar cantidades de pago Lightning en Satoshis")]
        public bool LightningAmountInSatoshi { get; set; }
        
        [Display(Name = "Redireccionar factura para redireccionar url automáticamente después de pagado")]
        public bool  RedirectAutomatically { get; set; }

        public void SetLanguages(LanguageService langService, string defaultLang)
        {
            defaultLang = langService.GetLanguages().Any(language => language.Code == defaultLang) ? defaultLang : "es-ES";
            var choices = langService.GetLanguages().Select(o => new Format() { Name = o.DisplayName, Value = o.Code }).ToArray();
            var chosen = choices.FirstOrDefault(f => f.Value == defaultLang) ?? choices.FirstOrDefault();
            Languages = new SelectList(choices, nameof(chosen.Value), nameof(chosen.Name), chosen);
            DefaultLang = chosen.Value;
        }
    }
}
