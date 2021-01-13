using DesignPatternSamples.Application.DTO;
using DesignPatternSamples.Application.Services;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSamples.Application.Decorators
{
    public class DetranVerificadorPontosDecoratorLogger : IDetranVerificadorPontosService
    {
        private readonly IDetranVerificadorPontosService _Inner;
        private readonly ILogger<DetranVerificadorPontosDecoratorLogger> _Logger;

        public DetranVerificadorPontosDecoratorLogger(
            IDetranVerificadorPontosService inner,
            ILogger<DetranVerificadorPontosDecoratorLogger> logger)
        {
            _Inner = inner;
            _Logger = logger;
        }

        public async Task<IEnumerable<PontoCarteira>> ConsultarPontoCarteira(Carteira carteira)
        {
            Stopwatch watch = Stopwatch.StartNew();
            _Logger.LogInformation($"Iniciando a execução do método ConsultarPontoCarteira({carteira})");
            var result = await _Inner.ConsultarPontoCarteira(carteira);
            watch.Stop();
            _Logger.LogInformation($"Encerrando a execução do método ConsultarPontoCarteira({carteira}) {watch.ElapsedMilliseconds}ms");
            return result;
        }
    } 
}
