namespace Firstcode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World");

            string s = "Hello all";
            Console.WriteLine(s);

            string firstname = "Arwa", lastname = "Fawzy";
            Console.WriteLine(firstname);
            Console.WriteLine(lastname);

            int age = 21, weight = 65; double height = 177.5; float water = 3.5f; decimal heightt=1.77m;
            bool istrue = false; char grade = 'A';
            Console.WriteLine(age);
            Console.WriteLine(weight);
            Console.WriteLine(height);
            Console.WriteLine(water);
            Console.WriteLine(heightt);
            Console.WriteLine(istrue);
            Console.WriteLine(grade);

            string fullname = firstname + " " + lastname;
            Console.WriteLine(fullname);

            string arwa = fullname.Substring(0, 4);
            Console.WriteLine(arwa);

            string aya = fullname.Replace("Arwa", "Aya");
            Console.WriteLine(aya);

            Console.WriteLine(fullname.Length);
            Console.WriteLine(fullname.IndexOf("Fawzy"));

            int result = 5 - 6 / 4 * 2;
            Console.WriteLine(result);

            Double x = 3;
            x = Math.Pow(x, 2);
            Console.WriteLine(x);



            Console.ReadLine();
        }
    }
}
