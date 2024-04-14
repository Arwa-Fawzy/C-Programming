using System.Xml.Serialization;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] ags)
        {
            SayHello();
            //concatenation
            Console.WriteLine("What is your name?");
            string s = Console.ReadLine();
            Console.WriteLine("Hello "+ s + '!');

            //converting data types
            Console.WriteLine("What is your first number?");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is your second number?");
            double num2 = Convert.ToInt64(Console.ReadLine());
            double result = num * num2;
            Console.WriteLine("The result is " + result);
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());
            HelloUser(s,age);
            string name=askname();
            Console.WriteLine("Hi " + name);

        }

        //Methods
        static void SayHello()
        {
            Console.WriteLine("Hello!");

        }

        //Methods parameters
        static void HelloUser(string s, int age)
        {
            Console.WriteLine("Hello "+ s+ " and your age is "+age);
        }

        //Methods returns
        static string askname()
        {
            Console.WriteLine("What is the name?");
            String ans = "Arwaaa";
            return ans;
        }




    }
}