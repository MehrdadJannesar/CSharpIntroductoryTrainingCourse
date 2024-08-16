//dataType[] name = new dataType[]

//string[] CsharpCourse = new string[10];

//string[] CsharpCourse2 = new string[5] { "Mehrdad", "Mehdi", "Ali", "Hassan","Zahra" };

//string[] CsharpCourse3 = new string[] { "Mehrdad", "Mehdi", "Ali", "Hassan","Zahra" };

//string[] CsharpCourse4 =  { "Mehrdad", "Mehdi", "Ali", "Hassan","Zahra" };

//string Value = CsharpCourse2[0];

////Console.WriteLine(Value);

////CsharpCourse.Append(Value);

//CsharpCourse[0] = Value;

////Console.WriteLine(CsharpCourse[0]);

//string search1 = Array.Find(CsharpCourse4, c => c.StartsWith("M"));

//Console.WriteLine(search1);

//var search2 = Array.FindAll(CsharpCourse4, c => c.StartsWith("M"));

//foreach (var item in search2)
//{
//    Console.WriteLine(item);
//}

//var search3 = Array.FindLast(CsharpCourse4, c => c.StartsWith("M"));

//Console.WriteLine(search3);

//int search4 = Array.FindIndex(CsharpCourse4, c => c.StartsWith("M"));

//Console.WriteLine(search4);

//int search5 = Array.FindLastIndex(CsharpCourse4, c => c.StartsWith("M"));

//Console.WriteLine(search5);

//====== List ========

//List<DataType> name = new List<DataType>();

List<int> numbers = new List<int>();
List<int> numbers1 = new List<int> { 1, 2, 3 };
List<string> contacts = new List<string>();
List<string> contacts1 = new List<string> { "Mehrnoosh","Sara","Shadi"};
List<string> contacts3 = new List<string>() { "Mehrnoosh","Sara","Shadi"};

//foreach (var contact in contacts1)
//{
//    Console.WriteLine(contact);
//}

contacts3.RemoveAt(2);
contacts3.Remove("Sara");
contacts3.Add("Mehrdad");
Console.WriteLine(contacts3.Contains("Mehrdad"));

contacts3.Insert(1, "Ali");

//contacts1.AddRange(contacts3);
contacts1.InsertRange(1,contacts3);

var result = contacts1.FirstOrDefault(c => c.Contains("M"));
var result2 = contacts1.LastOrDefault(c => c.Contains("M"));
Console.WriteLine(result);
//contacts1.ForEach(ct => Console.WriteLine(ct));

