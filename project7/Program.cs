namespace project7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;
            int c = 0;
            int d = 0;
            Console.WriteLine("请输入一串字符串");
            String s = Console.ReadLine();
            char[] sr = s.ToCharArray();
            for (int i = 0; i < sr.Length; i++)
            {
                if ('A' <= sr[i] && 'Z' >= sr[i] || 'a' <= sr[i] && 'z' >= sr[i])
                {
                    a++;
                }
                else if ('0' <= sr[i] && '9' >= sr[i])
                {
                    b++;
                }
                else if (sr[i] == ' ')
                {
                    c++;
                }
                else
                {
                    d++;
                }
            }
            Console.WriteLine("字母的个数为：" + a);
            Console.WriteLine("数字的个数为：" + b);
            Console.WriteLine("空格的个数为：" + c);
            Console.WriteLine("其他字符的个数为：" + d);

        }
    }
}