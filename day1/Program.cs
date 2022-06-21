using System;
namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrEmployees = { "Aman", "Rajan", "Nidhi", "Kamlesh", "Rohan", "Rajesh", "Gunjan", "Amol", "Naman", "Adity" };
            string[] Employees = new string[10];
            Array.Sort(arrEmployees);
            for(int i=0; i < Employees.Length; i++)
            {
                Employees[i] = arrEmployees[i];
                Console.WriteLine(Employees[i]);
            }
            //int rowLength = arrEmployees.Length - 1;
            //for (int i=0; i < arrEmployees.Length; i++)
            //{
            //    //Console.WriteLine(rowLength - i);
            //    Console.WriteLine(arrEmployees[rowLength - i]);
            //}
            //int rowLength = arrEmployees.Length - 1;
            for (int i = arrEmployees.Length-1; i >=0; i--)
            {
                Console.WriteLine(arrEmployees[i]);
            }
            Console.ReadLine();
        }
    }
}