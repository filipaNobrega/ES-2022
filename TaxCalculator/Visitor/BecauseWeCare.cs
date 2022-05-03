namespace TaxCalculatorLibrary.Visitor
{
    public class BecauseWeCare : FriendlyIrs
    {
        private const int Low = 1;
        private const int Pop = 50;

        protected override double Tax(Company company)
        {
            var taxes = base.Tax(company);
            if (company.Size < Pop || taxes < Low)
            {
                taxes *= .9;
            }
            return taxes;
        }

        protected override double Tax(Region region)
        {
            var taxes = base.Tax(region);
            if (region.Size < Pop || taxes < Low)
            {
                taxes *= .9;
            }
            return taxes;
        }
    }
}
