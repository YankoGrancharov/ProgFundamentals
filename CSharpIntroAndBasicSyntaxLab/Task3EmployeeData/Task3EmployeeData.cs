using System;
namespace Task3EmployeeData
{
    class Task3EmployeeData
    {
        static void Main()
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            int emplooye = int.Parse(Console.ReadLine());
            double salary = double.Parse(Console.ReadLine());
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Employee ID: {emplooye:D8}");
            Console.WriteLine($"Salary: {salary:F2}");
        }
    }
}
