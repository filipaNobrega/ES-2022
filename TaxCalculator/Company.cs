using System;
using System.Collections.Generic;

namespace TaxCalculatorLibrary
{
    public class Company : TaxPayer
    {
        private readonly List<Employee> _employees = new List<Employee>();

        public Company()
        {
            var random = new Random();
            var count = random.NextDouble() * 100;
            for (int i = 0; i < count; i++)
            {
                Add(new Employee());
            }
        }

        public int Size => _employees.Count;

        public Employee this[int index] => _employees[index];

        public void Add(Employee employee)
        {
            if (_employees.Contains(employee))
            {
                return;
            }
            _employees.Add(employee);
        }

        public void Remove(Employee employee)
        {
            if (!_employees.Contains(employee))
            {
                return;
            }
            _employees.Remove(employee);
        }
    }
}