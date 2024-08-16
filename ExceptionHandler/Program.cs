//try
//{
//    Console.WriteLine("Enter a number:");
//    var num = int.Parse(Console.ReadLine());
//    Console.WriteLine($"squre of {num} is {num * num}");
//}
//catch(Exception ex)
//{
//    Console.WriteLine($"Error info {ex.Message}");
//}
//finally
//{

//    Console.WriteLine("Re-try with a different number.");
//}

Console.WriteLine("Please enter a number to divide 100:");
try
{
	int num = int.Parse(Console.ReadLine());
	int result = 100 / num;
	Console.WriteLine($"100 / {num} = {result}");
}
catch (DivideByZeroException ex)
{
    Console.WriteLine("Connot divide by zero. Please try again!");
}
catch(InvalidOperationException ex)
{
    Console.WriteLine("Invalid operation. Please try again!");
}
catch(FormatException ex)
{
    Console.WriteLine("Not a valid format. Please try again!");
}
catch (Exception ex)
{
    Console.WriteLine($"Error info : {ex.Message}");
}
