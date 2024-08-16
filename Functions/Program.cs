//[access modifier][return type] FunctionName([parameters])
//{
//    // Function Body
//    return result;
//}

//class Program
//{
//    static void Main()
//    {
//        int number1 = 5;
//        int number2 = 10;
//        int result = AddNumbers(number1, number2);
//        Console.WriteLine(result);
//    }

//    public static int AddNumbers(int a, int b)
//    {
//        return a + b;
//    }
//}


//int number1 = 5;
//int number2 = 10;
//int result = AddNumbers(number1, number2);
//Console.WriteLine(result);

//static int AddNumbers(int a, int b)
//{
//    return a + b;
//}

//int number = 35;
//double squareRoot = Math.Sqrt(number);
//Console.WriteLine($"Square root of {number} is {squareRoot} ");

int number1 = 5;
var result = Factorial(number1);
Console.WriteLine(result);
static int Factorial(int number)
{
    if (number == 0)
    {
        return 1;
    }
    else
    {
        return number * Factorial(number - 1);
    }
}