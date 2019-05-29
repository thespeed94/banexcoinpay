using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using BTCPayServer.Services.Apps;
using BTCPayServer.Validation;

namespace BTCPayServer.Models.AppViewModels
{
    public class UpdateCrowdfundViewModel
    {
        [Required] [MaxLength(30)] public string Title { get; set; }

        [MaxLength(50)] public string Tagline { get; set; }

        [Required] public string Description { get; set; }
        
        [Display(Name = "Foto principal")]
        public string MainImageUrl { get; set; }
        
        [Display(Name = "Url de notificación")] 
        [Uri]
        public string NotificationUrl { get; set; }
        [Display(Name = "Notificación por correo electrónico")]
        [EmailAddress]
        public string NotificationEmail { get; set; }

        [Required]
        [Display(Name = "Permitir que el crowdfund sea visible públicamente (aún visible para usted)")]
        public bool Enabled { get; set; } = false;

        [Required]
        [Display(Name = "Habilitar animaciones de fondo en nuevos pagos.")]
        public bool AnimationsEnabled { get; set; } = true;

        [Required]
        [Display(Name = "Habilitar sonidos en nuevos pagos")]
        public bool SoundsEnabled { get; set; } = true;

        [Required]
        [Display(Name = "Habilitar comentarios Disqus")]
        public bool DisqusEnabled { get; set; } = true;

        [Display(Name = "Nombre Corto Disqus")] 
        public string DisqusShortname { get; set; }

        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        [Required]
        [MaxLength(5)]
        [Display(Name = "Moneda primaria utilizada para objetivos y estadísticas. (por ejemplo, BTC, LTC, USD, etc.)")]
        public string TargetCurrency { get; set; } = "BTC";

        [Display(Name = "Establecer una cantidad objetivo")]
        [Range(0, double.PositiveInfinity)]
        public decimal? TargetAmount { get; set; }


        public IEnumerable<string> ResetEveryValues = Enum.GetNames(typeof(CrowdfundResetEvery));

        [Display(Name = "Restablecer el objetivo cada")] 
        public string ResetEvery { get; set; } = nameof(CrowdfundResetEvery.Never);

        public int ResetEveryAmount { get; set; } = 1;


        [Display(Name = "No permitir contribuciones adicionales después de haber alcanzado el objetivo")]
        public bool EnforceTargetAmount { get; set; }

        [Display(Name = "Plantilla de beneficios de contribución")]
        public string PerksTemplate { get; set; }

        [MaxLength(500)]
        [Display(Name = "Archivo CSS bootstrap personalizado")]
        public string CustomCSSLink { get; set; }

        [Display(Name = "Código CSS personalizado")]
        public string EmbeddedCSS { get; set; }

        [Display(Name = "Cuente todas las facturas creadas en la tienda como parte del objetivo de crowdfunding")]
        public bool UseAllStoreInvoices { get; set; } 

        public string AppId { get; set; }
        public string SearchTerm { get; set; }

        [Display(Name = "Ordenar los beneficios de la contribución por popularidad")]
        public bool SortPerksByPopularity { get; set; }
        [Display(Name = "Mostrar ranking de contribución")]
        public bool DisplayPerksRanking { get; set; }


        [Display(Name = "Suena cuando se realiza un pago. Un sonido por linea")]
        public string Sounds{ get; set; }
        [Display(Name = "Colores para rotar con animación cuando se realiza un pago. El primer color es el fondo predeterminado. Un color por línea. Puede ser cualquier valor de color css válido.")]
        public string AnimationColors{ get; set; }

        public bool NotificationEmailWarning { get; set; }
    }
}
