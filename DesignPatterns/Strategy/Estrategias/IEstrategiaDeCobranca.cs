using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public interface IEstrategiaDeCobranca
    {
        public string descricaoEstrategia { get; set; }

        public string ObtenhaEstrategia();
    }

}
