// Напишіть програму, яка «запитуватиме» правильний пароль, доки він не буде введений.
// Правильний пароль нехай буде "root". Якщо пароль неправильний, програма повинна сказати "Неправильний пароль!"


string userPassword = "root";
Console.WriteLine("Hello, please enter the password");
do
{
    string userInput = Console.ReadLine();
    if (userPassword == userInput)
    {
        Console.WriteLine("Awesome. You entered the correct password!");
        break;
    }
    else
    {
        Console.WriteLine("Ohhhh. Sorry, but you password is incorrect");
    }
} while (true);