namespace project6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入第一个数：");
            int a1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("请输入第二个数：");
            int a2 = Convert.ToInt32(Console.ReadLine());

            int max = 0, min = 0;
            for (int i = 2; i <= (a1 < a2 ? a1 : a2); i++)
            {
                if (a1 % i == 0 && a2 % i == 0)
                {
                    max = i;
                }
            }

            for (int j = a1 * a2; j >= (a1 > a2 ? a1 : a2); j--)
            {
                if (j % a1 == 0 && j % a2 == 0)
                {
                    min = j;
                }
            }

            Console.WriteLine("最大公约数为：" + max);
            Console.WriteLine("最小公倍数为：" + min);

        }
    }
}