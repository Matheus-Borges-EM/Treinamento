using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Adapter
{
    public interface ClientBase
    {
        public virtual void ExecuteAcao(DadosEmXML dadosEmXml);
    }
}
