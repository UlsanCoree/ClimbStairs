namespace ClimbStairs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"50개의 계단을 올라가는 방법의 수는 : {ClimbStairs(50)}");
        }

        public static long ClimbStairs(int n)
        {
            if (n == 1)
            {
                return 1;
            }

            long[] differentMethod = new long[n + 1];
            differentMethod[1] = 1;
            differentMethod[2] = 2;

            for (int i = 3; i <= n; i++)
            {
                differentMethod[i] = differentMethod[i - 1] + differentMethod[i - 2];
            }
            return differentMethod[n];
        }
    }
}
