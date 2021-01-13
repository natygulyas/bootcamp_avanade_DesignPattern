using DesignPatternSamples.Application.DTO;
using DesignPatternSamples.Application.Repository;
using DesignPatternSamples.Application.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSamples.Application.Implementations
{
    public class DetranVerificadorPontosServices : IDetranVerificadorPontosService
    {
        private readonly IDetranVerificadorPontosFactory _Factory;

        public DetranVerificadorPontosServices(IDetranVerificadorPontosFactory factory)
        {
            _Factory = factory;
        }

        public Task<IEnumerable<PontoCarteira>> ConsultarPontoCarteira(Carteira carteira)
        {
            IDetranVerificadorPontosRepository repository = _Factory.Create(carteira.UF);
            return repository.ConsultarPontoCarteira(carteira);
        }
    }
}
