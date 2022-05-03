using System;
using System.Collections.Generic;

namespace TaxCalculatorLibrary
{
    public class Region : TaxPayer
    {
        private readonly List<Company> _companies = new List<Company>();

        public Region()
        {
            var random = new Random();
            var count = random.NextDouble() * 100;
            for (int i = 0; i < count; i++)
            {
                Add(new Company());
            }
        }

        public int Size => _companies.Count;

        public Company this[int index] => _companies[index];

        public void Add(Company company)
        {
            if (_companies.Contains(company))
            {
                return;
            }
            _companies.Add(company);
        }

        public void Remove(Company company)
        {
            if (!_companies.Contains(company))
            {
                return;
            }
            _companies.Remove(company);
        }
    }
}
