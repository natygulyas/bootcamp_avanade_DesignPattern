using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternSamples.WebAPI.Models.Detran
{
    public class PontoCarteiraModel
    {
        public DateTime DataOcorrencia { get; set; }
        public string Infracao { get; set; }
        public int Pontos { get; set; }
    }
}
