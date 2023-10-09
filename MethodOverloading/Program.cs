namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            var a = 5;
            var b = 10;

            var intSum = Add(a, b);
            var decSum = Add(5.5m, 3.2m);
            var strResult1 = Add(1, 5, true);
            var strResult2 = Add(1, 5, false);

            Console.WriteLine(intSum);
            Console.WriteLine(decSum);
            Console.WriteLine(strResult1);
            Console.WriteLine(strResult2);
        }

        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static decimal Add(decimal a, decimal b)
        {
            return a + b;
        }

        public static string Add(int a, int b, bool isChecked)
        {
            int sum = a + b;

            if (isChecked)
            {
                if (sum == 1)
                {
                    return $"{sum} dollar";
                }
                else
                {
                    return $"{sum} dollars";
                }
            }
            else
            {
                return sum.ToString();
            }
        }
    }
}
