namespace project9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            double height = 100;
            for (int i = 1; i <= 10; i++)
            {
                sum = height + height / 2 + sum;//一次落地距离+弹起距离+已经过路程
                height /= 2;//弹起高度为一半

            }
            sum -= height;//求第10次落地经过路程需减去第10次弹起距离
            Console.WriteLine("共经过" + sum + "米");
            Console.WriteLine("第10次弹起的高度为：" + height);
        }
    }
}