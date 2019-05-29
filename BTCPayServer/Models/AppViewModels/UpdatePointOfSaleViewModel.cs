using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using BTCPayServer.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BTCPayServer.Models.AppViewModels
{
    public class UpdatePointOfSaleViewModel
    {
        [Required]
        [MaxLength(30)]
        public string Title { get; set; }
        [Required]
        [MaxLength(5)]
        public string Currency { get; set; }
        public string Template { get; set; }

        [Display(Name = "Habilitar carrito de compras")]
        public bool EnableShoppingCart { get; set; }
        [Display(Name = "El usuario puede ingresar una cantidad personalizada")]
        public bool ShowCustomAmount { get; set; }
        [Display(Name = "El usuario puede ingresar el descuento en %")]
        public bool ShowDiscount { get; set; }
        [Display(Name = "Habilitar consejos")]
        public bool EnableTips { get; set; }
        public string Example1 { get; internal set; }
        public string Example2 { get; internal set; }
        public string ExampleCallback { get; internal set; }
        public string InvoiceUrl { get; internal set; }
        
        [Display(Name = "Url de notificación de devolución")] 
        [Uri]
        public string NotificationUrl { get; set; }
        [Display(Name = "Notificación por correo electrónico")]
        [EmailAddress]
        public string NotificationEmail { get; set; }

        [Required]
        [MaxLength(30)]
        [Display(Name = "Texto para mostrar en cada botón para artículos con un precio específico")]
        public string ButtonText { get; set; }
        [Required]
        [MaxLength(30)]
        [Display(Name = "Texto para mostrar en los botones junto a la entrada que permite al usuario ingresar una cantidad personalizada")]
        public string CustomButtonText { get; set; }
        [Required]
        [MaxLength(30)]
        [Display(Name = "Texto para mostrar en la entrada")]
        public string CustomTipText { get; set; }
        [MaxLength(30)]
        [Display(Name = "Porcentajes de las cantidades (separadas por comas)")]
        public string CustomTipPercentages { get; set; }

        [MaxLength(500)]
        [Display(Name = "Archivo CSS bootstrap personalizado")]
        public string CustomCSSLink { get; set; }

        public string Id { get; set; }

        [Display(Name = "Redireccionar factura para redireccionar url automáticamente después de pagado")]
        public string RedirectAutomatically { get; set; } = string.Empty;

        public SelectList RedirectAutomaticallySelectList =>
            new SelectList(new List< SelectListItem>()
            {
                new SelectListItem()
                {
                    Text = "Si",
                    Value = "true"
                },
                new SelectListItem()
                {
                    Text = "No",
                    Value = "false"
                },
                new SelectListItem()
                {
                    Text = "Usar configuración de tienda",
                    Value = ""
                }
            }, nameof(SelectListItem.Value), nameof(SelectListItem.Text), RedirectAutomatically);

        public bool NotificationEmailWarning { get; set; }
    }
}
