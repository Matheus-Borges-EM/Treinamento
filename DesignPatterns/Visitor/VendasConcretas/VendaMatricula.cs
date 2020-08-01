using System;
using Visitor.VisitorsConcretos;

namespace Visitor
{
    public class VendaMatricula : IVenda
    {
        public void AceiteVisitor(IVisitor visitor)
        {
            visitor.Visite(this);
        }
    }
}