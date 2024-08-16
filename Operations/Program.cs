int number1 = 20;
int number2 = 30;

int result = 0;

// x + y

//result = number1 + number2;
//result = number1 - number2;
//result = number1 / number2;
//result = number1 * number2;
//result = number1 % number2;

//// number1 = number1 + number2
//number1 += number2;
//number1 -= number2;
//number1 /= number2;
//number1 *= number2;
//number1 %= number2;

Console.WriteLine(number1 == number2);
Console.WriteLine(number1 != number2);
Console.WriteLine(number1 < number2);
Console.WriteLine(number1 > number2);
Console.WriteLine(number1 >= number2);
Console.WriteLine(number1 <= number2);

bool compare1 = true;
bool compare2 = false;

Console.WriteLine(compare1 && compare2); // false
Console.WriteLine(compare1 || compare2); // true
Console.WriteLine(!compare2); // true // Unary
Console.WriteLine("-----------------"); // true // Unary

int num1 = 5;
int num2 = 4;

Console.WriteLine(num1 & num2); // 0100
Console.WriteLine(num1 | num2); // 0101
Console.WriteLine(num1 ^ num2); // 0001