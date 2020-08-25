using System;
namespace MagicYearCalculator
{
    public class MagicYearCalculatorApplication
    {
        public static void Run()
        {
            var person = createPerson();
            displayMagicAgeDetails(person);
        }

        private static Person createPerson()
        {
            Console.WriteLine("Please enter your name");
            string name = Console.ReadLine();
            Console.WriteLine("Please enter your surname");
            string surname = Console.ReadLine();
            Console.WriteLine("Please enter your annual salary");
            double annaulSalary = Double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter your work start year");
            int workStartYear = Int32.Parse(Console.ReadLine());

            return new Person(name, surname, annaulSalary, workStartYear);
        }

        private static void displayMagicAgeDetails(Person person)
        {
            write("Your magic age details are:");
            Console.WriteLine($"Name: {person.Name} {person.Surname}");
            Console.WriteLine($"Monthly Salary: {Calculator.calculateMonthlySalary(person.AnnualSalary)}");
            Console.WriteLine($"Magic Year: {Calculator.calculateMagicYear(person.WorkStartYear)}");
        }

        private static void write(string text)
        {
            Console.WriteLine(text);
        }
    }
}
