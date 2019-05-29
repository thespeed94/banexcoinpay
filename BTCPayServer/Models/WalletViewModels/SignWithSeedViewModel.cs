using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using NBitcoin;

namespace BTCPayServer.Models.WalletViewModels
{
    public class SignWithSeedViewModel
    {
        [Required]
        public string PSBT { get; set; }
        [Required][Display(Name = "BIP39 Seed (12/24  palabra mnemotécnica) o clave privada HD (xprv...)")]
        public string SeedOrKey { get; set; }

        [Display(Name = "Frase de contraseña opcional")]
        public string Passphrase { get; set; }

        public ExtKey GetExtKey(Network network)
        {
            ExtKey extKey = null;
            try
            {
                var mnemonic = new Mnemonic(SeedOrKey);
                extKey = mnemonic.DeriveExtKey(Passphrase);
            }
            catch (Exception)
            {
            }

            if (extKey == null)
            {
                try
                {
                    extKey = ExtKey.Parse(SeedOrKey, network);
                }
                catch (Exception)
                {
                }
            }
            return extKey;
        }
    }
}
