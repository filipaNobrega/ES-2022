using TaxCalculatorLibrary.Visitor;
namespace TaxCalculatorLibrary
{
    public interface ITaxPayer
    {
        double Accept(IFriendlyIrs irs);
    }
}
