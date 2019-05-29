using BTCPayServer.Authentication;
using BTCPayServer.Filters;
using BTCPayServer.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using NBitcoin.DataEncoders;
using NBitpayClient;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BTCPayServer.Controllers
{
    [Authorize(AuthenticationSchemes = Security.Policies.BitpayAuthentication)]
    [BitpayAPIConstraint()]
    public class AccessTokenController : Controller
    {
        TokenRepository _TokenRepository;
        public AccessTokenController(TokenRepository tokenRepository)
        {
            _TokenRepository = tokenRepository ?? throw new ArgumentNullException(nameof(tokenRepository));
        }
        [HttpGet]
        [Route("tokens")]
        public async Task<GetTokensResponse> Tokens()
        {
            var tokens = await _TokenRepository.GetTokens(this.User.GetSIN());
            return new GetTokensResponse(tokens);
        }

        [HttpPost]
        [Route("tokens")]
        [AllowAnonymous]
        public async Task<DataWrapper<List<PairingCodeResponse>>> Tokens([FromBody] TokenRequest request)
        {
            if (request == null)
                throw new BitpayHttpException(400, "Falta el cuerpo de la solicitud");
            PairingCodeEntity pairingEntity = null;
            if (string.IsNullOrEmpty(request.PairingCode))
            {
                if (string.IsNullOrEmpty(request.Id) || !NBitpayClient.Extensions.BitIdExtensions.ValidateSIN(request.Id))
                    throw new BitpayHttpException(400, "'id' se requiere propiedad");

                var pairingCode = await _TokenRepository.CreatePairingCodeAsync();
                await _TokenRepository.PairWithSINAsync(pairingCode, request.Id);
                pairingEntity = await _TokenRepository.UpdatePairingCode(new PairingCodeEntity()
                {
                    Id = pairingCode,
                    Label = request.Label
                });

            }
            else
            {
                var sin = this.User.GetSIN() ?? request.Id;
                if (string.IsNullOrEmpty(sin) || !NBitpayClient.Extensions.BitIdExtensions.ValidateSIN(sin))
                    throw new BitpayHttpException(400, "'id' Se requiere propiedad, alternativamente, use BitId");

                pairingEntity = await _TokenRepository.GetPairingAsync(request.PairingCode);
                if (pairingEntity == null)
                    throw new BitpayHttpException(404, "El pairingCode especificado no se encuentra");
                pairingEntity.SIN = sin;

                if (string.IsNullOrEmpty(pairingEntity.Label) && !string.IsNullOrEmpty(request.Label))
                {
                    pairingEntity.Label = request.Label;
                    await _TokenRepository.UpdatePairingCode(pairingEntity);
                }

                var result = await _TokenRepository.PairWithSINAsync(request.PairingCode, sin);
                if (result != PairingResult.Complete && result != PairingResult.Partial)
                    throw new BitpayHttpException(400, $"Error mientras se empareja ({result})");

            }

            var pairingCodes = new List<PairingCodeResponse>
                {
                    new PairingCodeResponse()
                    {
                        Policies = new Newtonsoft.Json.Linq.JArray(),
                        PairingCode = pairingEntity.Id,
                        PairingExpiration = pairingEntity.Expiration,
                        DateCreated = pairingEntity.CreatedTime,
                        Facade = "merchant",
                        Token = pairingEntity.TokenValue,
                        Label = pairingEntity.Label
                    }
                };
            return DataWrapper.Create(pairingCodes);
        }
    }
}
