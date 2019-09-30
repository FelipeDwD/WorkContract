using System;
using WorkerContract.Entities.Enum;
using System.Globalization;
using WorkerContract.Entities;

namespace WorkerContract
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("pt-BR");

            Console.Write("Enter department´s name: ");
            string nameDpto = Console.ReadLine();
            Department department = new Department(nameDpto);
            Console.WriteLine("Enter worker data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Level (Junior/MidLevel/Senior): ");            
            WorkLevel level = Enum.Parse<WorkLevel>(Console.ReadLine());
            Console.Write("Base salary: ");
            double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("How many contracts to this worker? ");
            int contracts = int.Parse(Console.ReadLine());
            Worker worker = new Worker(name, level, salary, department);

            for (int i = 0; i < contracts; i++)
            {
                Console.WriteLine($"Enter #{(i + 1)} contract data: ");
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine(), culture);
                Console.WriteLine("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Duration (hours): ");
                double durationHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                HourContract hourContract = new HourContract(date, valuePerHour, durationHour);
                worker.AddContract(hourContract);                
            }
            Console.WriteLine();
            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            string monthAndYear = Console.ReadLine();
            int month = int.Parse(monthAndYear.Substring(0,2));
            int year = int.Parse(monthAndYear.Substring(3));
            Console.WriteLine($"Name: {worker.Name}");
            Console.WriteLine($"Department: {worker.Department.Name}");
            Console.WriteLine($" Total: {worker.Income(month, year).ToString("F2", CultureInfo.InvariantCulture)}");


        }
    }
}
