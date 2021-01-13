using DesignPatternSamples.Application.DTO;
using DesignPatternSamples.Application.Repository;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSamples.Infra.Repository.Detran
{
    public class DetranSPVerificadorPontosRepository : IDetranVerificadorPontosRepository
    {
        private readonly ILogger _Logger;

        public Task<IEnumerable<PontoCarteira>> ConsultarPontoCarteira(Carteira carteira)
        {
          _Logger.LogDebug($"Consultando pontos na carteira {carteira.Numero} para o estado de SP.");
            return Task.FromResult<IEnumerable<PontoCarteira>>(new List<PontoCarteira>() { new PontoCarteira() });
        }
    }
}
