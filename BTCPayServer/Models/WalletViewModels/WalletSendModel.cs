using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BTCPayServer.Models.WalletViewModels
{
    public class WalletSendModel
    {
    
        public List<TransactionOutput> Outputs { get; set; } = new List<TransactionOutput>();

        public class TransactionOutput
        {
            [Display(Name = "Dirección de destino")]
            [Required]
            public string DestinationAddress { get; set; }

            [Display(Name = "Cantidad")] [Required]  [Range(0.0, double.MaxValue)]public decimal? Amount { get; set; }


            [Display(Name = "El destino paga las tarifas mineras.")]
            public bool SubtractFeesFromOutput { get; set; }
        }
        public decimal CurrentBalance { get; set; }

        public string CryptoCode { get; set; }

        public int RecommendedSatoshiPerByte { get; set; }

        [Range(1, int.MaxValue)]
        [Display(Name = "Tarifa (satoshi por byte)")]
        [Required]
        public int FeeSatoshiPerByte { get; set; }

        [Display(Name = "Asegúrese de que no se crea ningún cambio UTXO")]
        public bool NoChange { get; set; }
        public decimal? Rate { get; set; }
        public int Divisibility { get; set; }
        public string Fiat { get; set; }
        public string RateError { get; set; }
        public bool SupportRBF { get; set; }
        [Display(Name = "Deshabilitar RBF")]
        public bool DisableRBF { get; set; }
    }
}
