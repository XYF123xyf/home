namespace project10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            int i, j, k;
            int count = 0;
            for (i = 1; i <= 4; i++)
            {
                for (j = 1; j <= 4; j++)
                {
                    for (k = 1; k <= 4; k++)
                    {
                        num = i * 100 + j * 10 + k;
                        if (i != j && i != k && j != k)
                        {
                            count++;
                            Console.WriteLine(num + "\t");
                        }
                        if (count % 5 == 0)
                        {
                            Console.WriteLine();
                        }
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("Total is " + count);
        }
    }
}