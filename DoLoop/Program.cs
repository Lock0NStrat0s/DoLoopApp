
bool isValidAge = false;
int age = 0;

//do
//{
//    Console.Write("What is your age: ");
//    string ageText = Console.ReadLine();

//    isValidAge = int.TryParse(ageText, out age);

//    if (!isValidAge)
//    {
//        Console.WriteLine("That was an invalid age.");
//    }
//} while (!isValidAge);

while (!isValidAge)
{
    Console.Write("What is your age: ");
    string ageText = Console.ReadLine();

    isValidAge = int.TryParse(ageText, out age);

    if (!isValidAge)
    {
        Console.WriteLine("That was an invalid age.");
    }
}

Console.WriteLine($"You age is {age}.");