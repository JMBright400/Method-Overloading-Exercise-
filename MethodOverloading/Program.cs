namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            var a = 5;
            var b = 10;

            var intAdd = Add(a, b);
            var decAdd = Add(a, b);
            var addWithBool = Add(a, b);

            Console.WriteLine(intAdd);
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
            var addedNumbers = a + b;

            if (isChecked && addedNumbers > 1)
            {
                return $"{addedNumbers} dollars";
            }
            else if ((isChecked && addedNumbers == 1))
            {
                return $"{addedNumbers} dollar";
            }
            else
            {
                return addedNumbers.ToString();
            }

        }

    }
}
