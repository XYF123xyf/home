namespace project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long num1 = 1;
            long num2 = 1;
            Console.WriteLine(num1);
            Console.WriteLine(num2);
            for (int i = 3; i <= 20; i++)
            {
                long temp = num2;
                num2 = num1 + num2;
                Console.WriteLine(num2);
                num1 = temp;
            }
        }
    }
}