// See https://aka.ms/new-console-template for more information
namespace Program
{
    class console
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number.");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number.");
            int num2 = int.Parse(Console.ReadLine());


            Console.WriteLine("The list of prime numbers between" + num1 + " and " + num2 + " is :");

            for (int i = num1; i <= num2; i++)
            {
                if (Check(i) == true)
                    Console.WriteLine(i);


            }


        }

        public static bool Check(int i)
        {
            bool prime = true;

            if (i == 0 || i == 1)
                prime = false;

            for (int k = 2; k <= i / 2; k++)
            {


                if ((i % k) == 0) prime = false;
            }
            return prime;
        }
    }

}
