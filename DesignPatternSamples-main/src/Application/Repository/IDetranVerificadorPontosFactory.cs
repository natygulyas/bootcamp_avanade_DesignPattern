using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSamples.Application.Repository
{
    public interface IDetranVerificadorPontosFactory
    {
        public IDetranVerificadorPontosFactory Register(string UF, Type repository);
        public IDetranVerificadorPontosRepository Create(string UF);
    }
}
