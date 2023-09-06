namespace project5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int score = Convert.ToInt32(Console.ReadLine());
            if (score < 60)
            {
                Console.WriteLine("C");
            }
            else if (score >= 60 && score <= 89)
            {
                Console.WriteLine("B");
            }
            else
            {
                Console.WriteLine("A");
            }
        }
    }
}