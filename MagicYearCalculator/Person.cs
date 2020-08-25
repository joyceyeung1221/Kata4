using System;
namespace MagicYearCalculator
{
    public class Person
    {
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public double AnnualSalary { get; private set; }
        public int WorkStartYear { get; private set; }

        public Person(string name,string surname,double annualSalary,int workStartyear)
        {
            Name = name;
            Surname = surname;
            AnnualSalary = annualSalary;
            WorkStartYear = workStartyear;
        }
    }
}
