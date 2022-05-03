namespace TaxCalculatorLibrary.Visitor
{
    public interface IFriendlyIrs
    {
        double Tax(ITaxPayer payer);
    }
}
