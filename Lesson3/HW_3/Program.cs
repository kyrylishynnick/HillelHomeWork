//Дано тризначне число. Знайти число, отримане під час перестановки першої та другої цифр заданого числа.

int number = 246;

int firstTemporaryDig;
int secondTemporaryDig;
int thirtdTemporaryDig;


firstTemporaryDig = number / 100;
secondTemporaryDig = number / 10 % 10;
thirtdTemporaryDig = number % 10;

int revercedNumber = secondTemporaryDig * 100 + firstTemporaryDig * 10 + thirtdTemporaryDig;

Console.WriteLine($"The reverce number is: {revercedNumber}");
