using BTCPayServer.Services;
using BTCPayServer.Services.Invoices;
using BTCPayServer.Services.Rates;
using BTCPayServer.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BTCPayServer.Models.StoreViewModels
{
    public class StoreViewModel
    {
        public class DerivationScheme
        {
            public string Crypto { get; set; }
            public string Value { get; set; }
            public WalletId WalletId { get; set; }
            public bool Enabled { get; set; }
        }
        
        public class ThirdPartyPaymentMethod
        {
            public string Provider { get; set; }
            public bool Enabled { get; set; }
            public string Action { get; set; }
        }
        public StoreViewModel()
        {

        }

        public bool CanDelete { get; set; }
        public string Id { get; set; }
        [Display(Name = "Nombre de la tienda")]
        [Required]
        [MaxLength(50)]
        [MinLength(1)]
        public string StoreName
        {
            get; set;
        }

        [Uri]
        [Display(Name = "Sitio web de la tienda")]
        [MaxLength(500)]
        public string StoreWebsite
        {
            get;
            set;
        }

        [Display(Name = "Permitir que cualquiera cree factura.")]
        public bool AnyoneCanCreateInvoice { get; set; }

        public List<StoreViewModel.DerivationScheme> DerivationSchemes { get; set; } = new List<StoreViewModel.DerivationScheme>();

        public List<ThirdPartyPaymentMethod> ThirdPartyPaymentMethods { get; set; } =
            new List<ThirdPartyPaymentMethod>();

        [Display(Name = "La factura vence si no se ha pagado el monto total después de ... minutos")]
        [Range(1, 60 * 24 * 24)]
        public int InvoiceExpiration
        {
            get;
            set;
        }

        [Display(Name = "Pago inválido si las transacciones no pueden confirmar ... minutos después del vencimiento de la factura")]
        [Range(10, 60 * 24 * 24)]
        public int MonitoringExpiration
        {
            get;
            set;
        }

        [Display(Name = "Considerar la factura confirmada al momento de la transacción de pago....")]
        public SpeedPolicy SpeedPolicy
        {
            get; set;
        }

        [Display(Name = "Agregar una tarifa adicional (tarifa de red) a la factura...")]
        public Data.NetworkFeeMode NetworkFeeMode
        {
            get; set;
        }

        [Display(Name = "Plantilla de descripción de la factura del Lightning.")]
        public string LightningDescriptionTemplate { get; set; }

        public class LightningNode
        {
            public string CryptoCode { get; set; }
            public string Address { get; set; }
            public bool Enabled { get; set; }
        }
        public List<LightningNode> LightningNodes
        {
            get; set;
        } = new List<LightningNode>();

        [Display(Name = "Considere la factura pagada incluso si el monto pagado es ...% menos de lo esperado")]
        [Range(0, 100)]
        public double PaymentTolerance
        {
            get;
            set;
        }
    }
}
