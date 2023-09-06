namespace project4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("请输入数字：");
            int num = Convert.ToInt32(Console.ReadLine());
            int x = 2;
            Console.Write(num + "=");
            while (x <= num)
            {//通过循环来找到可以被整除的数，然后通过控制台打印输出
                if (x == num)
                {//如果相等的话，说明这个数没有因数，只有1和它本身
                    Console.Write(x);
                    break;
                }
                else if (num % x == 0)
                { //如果这个数有因数，然后除去这个因数的值后，继续循环
                    Console.Write(x + "*");
                    num = num / x;
                }
                else
                {
                    x++;//如果都不满足，则继续循环
                }
            }
        }
    }
}