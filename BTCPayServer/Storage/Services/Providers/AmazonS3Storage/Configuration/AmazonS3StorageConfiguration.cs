using BTCPayServer.Storage.Services.Providers.Models;
using TwentyTwenty.Storage.Amazon;
using System.ComponentModel.DataAnnotations;

namespace BTCPayServer.Storage.Services.Providers.AmazonS3Storage.Configuration
 {
     public class AmazonS3StorageConfiguration : AmazonProviderOptions, IBaseStorageConfiguration
     {
         [Display(Name="Nombre del contenedor")]
         public string ContainerName { get; set; }
     }
 }