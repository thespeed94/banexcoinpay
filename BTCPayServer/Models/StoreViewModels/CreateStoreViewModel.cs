using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace BTCPayServer.Models.StoreViewModels
{
    public class CreateStoreViewModel
    {
        [Required]
        [MaxLength(50)]
        [MinLength(1)]
        [Display(Name="Nombre")]
        public string Name
        {
            get; set;
        }
    }
}
