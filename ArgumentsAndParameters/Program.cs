
Console.WriteLine("Enter a world");
string userInput = Console.ReadLine();

PrintAnyWorld(userInput); //userInput - argument




static void PrintAnyWorld(string anyString) //anyString - parameter
{
    anyString = anyString.ToUpper();
    for(int i = 0; i < 5; i++)
    {
        Console.WriteLine(anyString);
    }
}
