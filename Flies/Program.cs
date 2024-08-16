using System.IO;

//string path = "H:\\example.txt";
//string content = "Welcome to C# course!";
//File.WriteAllText(path, content);

string path = "H:\\example.txt";
if (File.Exists(path))
{
    string content = File.ReadAllText(path);
    Console.WriteLine(content);
}