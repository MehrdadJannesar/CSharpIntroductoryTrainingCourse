//if (conditions)
//{
//    // code ... 
//}

string name = "C# Course";

if (name == "C# Course2")
{
    Console.WriteLine("Ok!");
}
else
{
    Console.WriteLine("Not match!");
}

//---------------
//if (condtions)
//{
//    //code
//}
//else if(condition 2){

//}
//else if (condition 3){

//}
//else
//{

//}

int i = 15;

if (i == 10)
{
    Console.WriteLine("i is 10");
}
else if (i == 15)
{
    Console.WriteLine("i is 15");
}
else if (i == 16)
{
    Console.WriteLine("i is 16");
}
else
{
    Console.WriteLine("i is 20");
}

//if (condition1)
//{
//    if (condition2)
//    {

//    }
//    else
//    {
//    }
//}
//else
//{

//}


int j = 13;

if (j == 10)
{
    if (j < 12)
    {
        Console.WriteLine("j is smaller than 12 too");
    }
    else
    {
        Console.WriteLine("j is greater than 15");
    }
}
else
{
    Console.WriteLine("j is greater than 10");
}

// -----------------

//switch (x)
//{
//    case 1: //code
//        break;
//}

int number = 50;

switch (number)
{
    case 10:
        Console.WriteLine("case 10");
        break;
    case 15:
        Console.WriteLine("case 15");
        break;
    case 30:
        Console.WriteLine("case 30");
        break;
    default:
        Console.WriteLine("not match!");
        break;
}

int number1 = 15;

switch (number1)
{
    case 5:
        Console.WriteLine(5);
        switch (number1 - 1)
        {
            case 4:
                Console.WriteLine(4);
                switch (number1 - 2)
                {
                    case 3:
                        Console.WriteLine(3);
                        break;
                }
                break;
        }
        break;
    case 10:
        Console.WriteLine(10);
        break;
        case 15:
        Console.WriteLine(15);
        break;
    default:
        Console.WriteLine(100);
        break;
}





