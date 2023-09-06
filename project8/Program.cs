namespace project8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;                            //定义所有因子的和
            for (int i = 1; i <= 1000; i++)
            {
                sum = 0;                            //每次循环，sum重新归零
                for (int n = 1; n < i; n++)
                {             //找出这个数的所有因子
                    if (i % n == 0)
                    {
                        sum = sum + n;                //所有的因子相加
                    }
                }
                if (i == sum)
                {                       //判断这个数是否是完数，既所有因子之和与它本身是否相等
                    Console.WriteLine(sum);      //打印完数
                }
            }
        }
    }
}