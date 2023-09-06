namespace project3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 100; i < 1000; i++)
            {
                int g = i % 10;
                int s = i % 100 / 10;
                int b = i / 100;
                if (g * g * g + s * s * s + b * b * b == i)
                    Console.WriteLine(i + "\t");
            }
        }
    }
}