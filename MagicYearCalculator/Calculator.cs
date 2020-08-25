using System;
namespace MagicYearCalculator
{
    public class Calculator
    {

        private const int MagicNumber = 65;

        public static int calculateMonthlySalary(double annualSalary)
        {
            double monthlySalary = annualSalary / 12;
            double roundedmonthlySalary = monthlySalary % 1 > 0.50 ? Math.Ceiling(monthlySalary) : Math.Floor(monthlySalary);
            return Convert.ToInt32(roundedmonthlySalary);
        }

        public static int calculateMagicYear(int workStartYear)
        {
            return workStartYear + MagicNumber;
        }
    }
}
