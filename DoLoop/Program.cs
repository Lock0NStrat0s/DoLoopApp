
bool isValidAge;
int age;

do
{
    Console.Write("What is your age: ");
    string ageText = Console.ReadLine();

    isValidAge = int.TryParse(ageText, out age);

    if (!isValidAge)
    {
        Console.WriteLine("That was an invalid age.");
    }
} while (!isValidAge);

Console.WriteLine($"You age is {age}.");