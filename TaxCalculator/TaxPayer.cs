using TaxCalculatorLibrary.Visitor;

namespace TaxCalculatorLibrary
{
    public abstract class TaxPayer : ITaxPayer
    {
        public double Accept(IFriendlyIrs irs)
        {
            return irs.Tax(this);
        }
    }
}
