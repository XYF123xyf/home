namespace project2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            for (int i = 101; i < 200; i += 2)
            {
                bool b = false;
                for (int j = 2; j <= System.Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        b = false; break;
                    }
                    else
                    {
                        b = true;
                    }
                }
                if (b == true)
                {
                    count++;
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine("素数个数是: " + count);
        }

    }
}