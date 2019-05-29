using System;
using System.Threading.Tasks;
using BTCPayServer.Data;
using BTCPayServer.Models.ServerViewModels;
using BTCPayServer.Models.StoreViewModels;
using BTCPayServer.Payments.Changelly;
using BTCPayServer.Services.Mails;
using Microsoft.AspNetCore.Mvc;

namespace BTCPayServer.Controllers
{
    public partial class StoresController
    {
        
        [Route("{storeId}/emails")]
        public IActionResult Emails()
        {
            var store = HttpContext.GetStoreData();
            if (store == null)
                return NotFound();
            var data = store.GetStoreBlob().EmailSettings ?? new EmailSettings();
            return View(new EmailsViewModel() { Settings = data });
        }
        
        [Route("{storeId}/emails")]
        [HttpPost]
        public async Task<IActionResult> Emails(string storeId, EmailsViewModel model, string command)
        {
            var store = HttpContext.GetStoreData();
            if (store == null)
                return NotFound();
            if (command == "Test")
            {
                try
                {
                    if (!model.Settings.IsComplete())
                    {
                        model.StatusMessage = "Error: Faltan campos obligatorios";
                        return View(model);
                    }
                    var client = model.Settings.CreateSmtpClient();
                    await client.SendMailAsync(model.Settings.From, model.TestEmail, "BTCPay test", "BTCPay test");
                    model.StatusMessage = "Correo electrónico enviado a " + model.TestEmail + ", por favor verifica que lo recibiste";
                }
                catch (Exception ex)
                {
                    model.StatusMessage = "Error: " + ex.Message;
                }
                return View(model);
            }
            else // if(command == "Save")
            {
                
                var storeBlob = store.GetStoreBlob();
                storeBlob.EmailSettings = model.Settings;
                store.SetStoreBlob(storeBlob);
                await _Repo.UpdateStore(store);
                StatusMessage = "Configuraciones de correo electrónico modificadas";
                return RedirectToAction(nameof(UpdateStore), new {
                    storeId});

            }
        }
    }
}
