

namespace Visitor
{
    public class VendaMaterial : IVenda
    {
        public void AceiteVisitor(IVisitor visitor)
        {
            visitor.Visite(this);
        }
    }
}