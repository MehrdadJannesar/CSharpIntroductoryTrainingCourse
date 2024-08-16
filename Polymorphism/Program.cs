//using Polymorphism;

//TestStaticPolymorphism testStaticPolymorphism =
//    new TestStaticPolymorphism();

//int add1 = testStaticPolymorphism.Add(20, 30, 20);
//int add2 = testStaticPolymorphism.Add(30, 20);

////Console.ReadKey();

//Complex c1 = new Complex(1.0,2.0);
//Complex c2 = new Complex(3.0, 4.0);

//Complex result = c1 + c2;

//Console.WriteLine($"Result = {result}");

using Polymorphism;

Interest interest = new Interest();
double finalAmount = interest.TrueBank(5000.00, 0.1);
Console.WriteLine($"Normal interest for holder {finalAmount}");

interest = new SimpleInterest();

finalAmount = interest.TrueBank(5000.00, 0.1);
Console.WriteLine($"Simple interest for holder {finalAmount}");

