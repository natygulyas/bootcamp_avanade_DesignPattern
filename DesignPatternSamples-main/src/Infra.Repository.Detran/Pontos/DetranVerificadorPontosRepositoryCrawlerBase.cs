using DesignPatternSamples.Application.DTO;
using DesignPatternSamples.Application.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSamples.Infra.Repository.Detran
{
    public abstract class DetranVerificadorPontosRepositoryCrawlerBase : IDetranVerificadorPontosRepository
    {
        public async Task<IEnumerable<PontoCarteira>> ConsultarPontoCarteira(Carteira carteira)
        {
            var html = await RealizarAcesso(carteira);
            return await PadronizarResultado(html);
        }

        protected abstract Task<string> RealizarAcesso(Carteira carteira);
        protected abstract Task<IEnumerable<PontoCarteira>> PadronizarResultado(string html);

    }
}
