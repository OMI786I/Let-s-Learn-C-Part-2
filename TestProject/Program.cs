Console.WriteLine("Hello, World!");

string name = "omi";
name = name.ToUpper();
Console.WriteLine(name);

Random random = new Random();
Console.WriteLine(random.Next(1, 100));

Random dice = new(); //new approach to create an instance of a class
Console.WriteLine(dice.Next(1, 6));