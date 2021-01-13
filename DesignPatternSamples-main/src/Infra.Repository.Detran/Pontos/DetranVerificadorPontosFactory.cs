using DesignPatternSamples.Application.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSamples.Infra.Repository.Detran
{
    public class DetranVerificadorPontosFactory : IDetranVerificadorPontosFactory
    {
        private readonly IServiceProvider _ServiceProvider;
        private readonly IDictionary<string, Type> _Repositories = new Dictionary<string, Type>();

        public DetranVerificadorPontosFactory(IServiceProvider serviceProvider)
        {
            _ServiceProvider = serviceProvider;
        }

        public IDetranVerificadorPontosRepository Create(string UF)
        {
            IDetranVerificadorPontosRepository result = null;

            if (_Repositories.TryGetValue(UF, out Type type))
            {
                result = _ServiceProvider.GetService(type) as IDetranVerificadorPontosRepository;
            }

            return result;
        }

        public IDetranVerificadorPontosFactory Register(string UF, Type repository)
        {
            if (!_Repositories.TryAdd(UF, repository))
            {
                _Repositories[UF] = repository;
            }

            return this;
        }

    }
}
