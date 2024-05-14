namespace C__Project
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello my name is Mohammad");

            Console.WriteLine("Hello! My Name is Zandar :D");
            Console.WriteLine("My name is George");
            Console.WriteLine("Hello comrades, my name is Caleb");


            string num1, num2, temp;
            Console.WriteLine("Enter a number");
            num1 = Console.ReadLine();
            Console.WriteLine("Enter another number");
            num2 = Console.ReadLine();

            Double V1, V2;
            V1 = Convert.ToDouble(num1);
            V2 = Convert.ToDouble(num2);

            Console.WriteLine($"{V1} plus {V2} equals {V1 + V2} ");
            Console.WriteLine($"{V1} minus {V2} equals {V1 - V2} ");
            Console.WriteLine($"{V1} times {V2} equals {V1*V2} ");
            Console.WriteLine($"{V1} divide by {V2} equals {V1/V2} ");


        }





    }
}
