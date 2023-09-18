namespace Chijesta
{
    class CC
    {
        static void Main()
        {
            int a = 3;
            int b = Sum(1);
            int c = Sum(a, b);
        }
        static int Sum(int x, int y)
        {
            return x + y;

        }
        static int Sum(int z)
        {
            return z + 1;

        }
    }
}
