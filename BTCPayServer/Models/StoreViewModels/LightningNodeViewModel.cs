﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BTCPayServer.Models.StoreViewModels
{
    public class LightningNodeViewModel
    {
        [Display(Name = "Cadena de conexión")]
        public string ConnectionString
        {
            get;
            set;
        }

        public string CryptoCode
        {
            get;
            set;
        }
        public string StatusMessage { get; set; }
        public string InternalLightningNode { get; internal set; }
        public bool SkipPortTest { get; set; }
        public bool Enabled { get; set; } = true;

        public string StoreId { get; set; }
    }
}
