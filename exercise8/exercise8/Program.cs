using System.ComponentModel;

namespace exercise8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter number of evens (2-10):");
            int n = int.Parse(Console.ReadLine());
            
            // print the evens from 2 to 10
            for (int i = 0; i <= n; i+=2)
            {
                Console.WriteLine(i);
            }
            // problem 2 
            Console.WriteLine("enter number of asterisk");
           int asterisks = int.Parse(Console.ReadLine());
            // print asterisk 5 times in a row 
              
            for (int i = 0; i < asterisks; i++)
            {
                Console.Write("*");
            }
        }
    }
}