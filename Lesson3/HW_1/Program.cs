//Дано тризначне число. Знайти число, отримане під час прочитання його цифр справа наліво.

int number = 123;
int symbol1;
int symbol2;
int symbol3;
int firstTemporaryDig;
int secondTemporaryDig;



symbol1 = number % 10;
firstTemporaryDig = number / 10;
symbol2 = firstTemporaryDig % 10;
secondTemporaryDig = number / 10;
symbol3 = firstTemporaryDig / 10;


int reversedNumber = symbol1 * 100 + symbol2 * 10 + symbol3;

Console.WriteLine($"The reverce number is: {reversedNumber}");