using System;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using BTCPayServer.Models.AppViewModels;
using BTCPayServer.Services.Apps;
using BTCPayServer.Services.Mails;
using Microsoft.AspNetCore.Mvc;

namespace BTCPayServer.Controllers
{
    public partial class AppsController
    {
        public class AppUpdated
        {
            public string AppId { get; set; }
            public object Settings { get; set; }
            public string StoreId { get; set; }
            public override string ToString()
            {
                return String.Empty;
            }
        }
        
        
        [HttpGet]
        [Route("{appId}/settings/crowdfund")]
        public async Task<IActionResult> UpdateCrowdfund(string appId)
        {
            var app = await GetOwnedApp(appId, AppType.Crowdfund);
            if (app == null)
                return NotFound();
            var settings = app.GetSettings<CrowdfundSettings>();
            var vm = new UpdateCrowdfundViewModel()
            {
                NotificationEmailWarning = !await IsEmailConfigured(app.StoreDataId),
                Title = settings.Title,
                Enabled = settings.Enabled,
                EnforceTargetAmount = settings.EnforceTargetAmount,
                StartDate = settings.StartDate,
                TargetCurrency = settings.TargetCurrency,
                Description = settings.Description,
                MainImageUrl = settings.MainImageUrl,
                EmbeddedCSS = settings.EmbeddedCSS,
                EndDate = settings.EndDate,
                TargetAmount = settings.TargetAmount,
                CustomCSSLink = settings.CustomCSSLink,
                NotificationUrl = settings.NotificationUrl,
                Tagline = settings.Tagline,
                PerksTemplate = settings.PerksTemplate,
                DisqusEnabled = settings.DisqusEnabled,
                SoundsEnabled = settings.SoundsEnabled,
                DisqusShortname = settings.DisqusShortname,
                AnimationsEnabled = settings.AnimationsEnabled,
                ResetEveryAmount = settings.ResetEveryAmount,
                ResetEvery = Enum.GetName(typeof(CrowdfundResetEvery), settings.ResetEvery),
                UseAllStoreInvoices = app.TagAllInvoices,
                AppId = appId,
                SearchTerm = app.TagAllInvoices ? $"storeid:{app.StoreDataId}" : $"orderid:{AppService.GetCrowdfundOrderId(appId)}",
                DisplayPerksRanking = settings.DisplayPerksRanking,
                SortPerksByPopularity = settings.SortPerksByPopularity,
                Sounds                = string.Join(Environment.NewLine, settings.Sounds),
                AnimationColors                = string.Join(Environment.NewLine, settings.AnimationColors)
            };
            return View(vm);
        }
        [HttpPost]
        [Route("{appId}/settings/crowdfund")]
        public async Task<IActionResult> UpdateCrowdfund(string appId, UpdateCrowdfundViewModel vm)
        {
            if (!string.IsNullOrEmpty( vm.TargetCurrency) && _currencies.GetCurrencyData(vm.TargetCurrency, false) == null)
                ModelState.AddModelError(nameof(vm.TargetCurrency), "Moneda invalida");
          
            try
            {
                _AppService.Parse(vm.PerksTemplate, vm.TargetCurrency).ToString();
            }
            catch
            {
                ModelState.AddModelError(nameof(vm.PerksTemplate), "Plantilla inválida");
            }

            if (Enum.Parse<CrowdfundResetEvery>(vm.ResetEvery) != CrowdfundResetEvery.Never && !vm.StartDate.HasValue)
            {
                ModelState.AddModelError(nameof(vm.StartDate), "Se necesita una fecha de inicio cuando el objetivo se restablece cada X cantidad de tiempo.");
            }

            if (Enum.Parse<CrowdfundResetEvery>(vm.ResetEvery) != CrowdfundResetEvery.Never && vm.ResetEveryAmount <= 0)
            {
                ModelState.AddModelError(nameof(vm.ResetEveryAmount), "Debes restablecer el objetivo en un mínimo de 1. ");
            }

            if (vm.DisplayPerksRanking && !vm.SortPerksByPopularity)
            {
                ModelState.AddModelError(nameof(vm.DisplayPerksRanking), "Debes ordenar por popularidad para poder mostrar el ranking.");
            }

            var parsedSounds = vm.Sounds.Split(
                new[] {"\r\n", "\r", "\n"},
                StringSplitOptions.None
            ).Select(s => s.Trim()).ToArray();
            if (vm.SoundsEnabled && !parsedSounds.Any())
            {
                ModelState.AddModelError(nameof(vm.Sounds), "Debes tener al menos un sonido si habilitas los sonidos");
            }
            
            var parsedAnimationColors = vm.AnimationColors.Split(
                new[] { "\r\n", "\r", "\n" },
                StringSplitOptions.None
            ).Select(s => s.Trim()).ToArray();
            if (vm.AnimationsEnabled && !parsedAnimationColors.Any())
            {
                ModelState.AddModelError(nameof(vm.AnimationColors), "Debe tener al menos un color de animación si habilita las animaciones");
            }
            
            if (!ModelState.IsValid)
            {
                return View(vm);
            }
            
            
            var app = await GetOwnedApp(appId, AppType.Crowdfund);
            if (app == null)
                return NotFound();

            var newSettings = new CrowdfundSettings()
            {
                Title = vm.Title,
                Enabled = vm.Enabled,
                EnforceTargetAmount = vm.EnforceTargetAmount,
                StartDate = vm.StartDate?.ToUniversalTime(),
                TargetCurrency = vm.TargetCurrency,
                Description = _htmlSanitizer.Sanitize( vm.Description),
                EndDate = vm.EndDate?.ToUniversalTime(),
                TargetAmount = vm.TargetAmount,
                CustomCSSLink = vm.CustomCSSLink,
                MainImageUrl = vm.MainImageUrl,
                EmbeddedCSS = vm.EmbeddedCSS,
                NotificationUrl = vm.NotificationUrl,
                NotificationEmail = vm.NotificationEmail,
                Tagline = vm.Tagline,
                PerksTemplate = vm.PerksTemplate,
                DisqusEnabled = vm.DisqusEnabled,
                SoundsEnabled = vm.SoundsEnabled,
                DisqusShortname = vm.DisqusShortname,
                AnimationsEnabled = vm.AnimationsEnabled,
                ResetEveryAmount = vm.ResetEveryAmount,
                ResetEvery = Enum.Parse<CrowdfundResetEvery>(vm.ResetEvery),
                DisplayPerksRanking = vm.DisplayPerksRanking,
                SortPerksByPopularity = vm.SortPerksByPopularity,
                Sounds = parsedSounds,
                AnimationColors = parsedAnimationColors
            };

            app.TagAllInvoices = vm.UseAllStoreInvoices;
            app.SetSettings(newSettings);
            await UpdateAppSettings(app);

            _EventAggregator.Publish(new AppUpdated()
            {
                AppId = appId,
                StoreId = app.StoreDataId,
                Settings = newSettings
            });
            StatusMessage = "Aplicación actualizada";
            return RedirectToAction(nameof(UpdateCrowdfund), new {appId});
        }
    }
}
