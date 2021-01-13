using DesignPatternSamples.Application.DTO;
using DesignPatternSamples.Application.Services;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using Workbench.IDistributedCache.Extensions;

namespace DesignPatternSamples.Application.Decorators
{
   public class DetranVerificadorPontosDecoratorCache : IDetranVerificadorPontosService
    {
        private readonly IDetranVerificadorPontosService _Inner;
        private readonly IDistributedCache _Cache;

        public DetranVerificadorPontosDecoratorCache(
            IDetranVerificadorPontosService inner,
            IDistributedCache cache)
        {
            _Inner = inner;
            _Cache = cache;
        }

        public Task<IEnumerable<PontoCarteira>> ConsultarPontoCarteira(Carteira carteira)
        {
            return Task.FromResult(_Cache.GetOrCreate($"{carteira.UF}_{carteira.Numero}", () => _Inner.ConsultarPontoCarteira(carteira).Result));
        }

    }
}
