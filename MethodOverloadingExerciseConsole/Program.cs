
class Program
{
    static void Main (string[] args)
    {
        var answer = Add(20, 30);

        var decimalAnswer = Add(31.0m, 42.0m);

        var thirdAnswer = Add(0, 0, true);

        Console.WriteLine($"int add: {answer} decimal add: {decimalAnswer}");
        Console.WriteLine(thirdAnswer);

    }
    
        static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        static decimal Add(decimal num1, decimal num2)
        {
            return num1 + num2;
        }

        static string Add(int num1, int num2, bool isCheck)
        {
            var sum = num1 + num2;
            if (isCheck == true && sum > 1)
            {
                return $"{sum} dollars";
            }
            if (isCheck == true && sum == 1)
            {
                return $"{sum} dollar";
            }
            if (isCheck == true && sum < 1)
            {
                return $"{sum} dollars";
            }
            else
            {
                return sum.ToString();
            }
        }
}

