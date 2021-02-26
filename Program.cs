System.Console.Write("Who would you like to say hello to? ");

string name = System.Console.ReadLine();

if (string.IsNullOrWhiteSpace(name))
{
    System.Console.WriteLine("Fine, don't say 'hello'!");
}
else
{
    System.Console.WriteLine($"Hello, {name}!");
}