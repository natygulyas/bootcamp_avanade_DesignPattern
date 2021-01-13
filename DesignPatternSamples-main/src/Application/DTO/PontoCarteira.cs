using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSamples.Application.DTO
{
    [Serializable]
    public class PontoCarteira
    {
        public DateTime DataOcorrencia { get; set; }
        public string Infracao { get; set; }
        public double Pontos { get; set; }
    }
}
