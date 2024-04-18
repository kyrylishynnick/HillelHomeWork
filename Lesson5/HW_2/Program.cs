// Програма загадує число від 1 до 146 (привіт, Random).
// Користувач намагається вгадати його. У разі неправильної відповіді програма підказує «більше» або «менше»

Random random = new Random();
int randomNumber = random.Next(1, 146);
Console.WriteLine($"The generated number is: {randomNumber}");
Console.WriteLine("Hello, try to guess the number were generated");

while (true)
{
    int userGuess = int.Parse(Console.ReadLine());
    if (randomNumber == userGuess)
    {
        Console.WriteLine("Hey. You are lucky. You choice is rigth!");
        break;
    }
    else
    {
        Console.WriteLine("Hmmmm. You made a mistake. Try again!");
    }
}