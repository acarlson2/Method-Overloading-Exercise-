namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add(1,2));
            Console.WriteLine(Add(1.5m,2.3m));
            Console.WriteLine(Add(1,2,false));
            Console.WriteLine(Add(0,1,true));
            Console.WriteLine(Add(1,2,true));
        }

        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static decimal Add(decimal num1, decimal num2)
        {
            return num1 + num2;
        }

        public static string Add(int num1, int num2, bool isMoney)
        {
            string retVal;
            int sum = num1 + num2;

            if(isMoney)
            {
                if(sum == 1)
                {
                    retVal = $"{sum} dollar";
                }
                else
                {
                    retVal = $"{sum} dollars";
                }
            }
            else
            {
                retVal = $"{sum}";
            }

            return retVal;
        }
    }
}
