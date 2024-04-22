//Задати масив із 10 елементів. Заповнити цей масив рандомними числами від -100 до 100.
//Знайти кількість додатніх чисел у масиві.
//Вивести на екран масив і кількість порахованих чисел.
//{5, -9, 8, 7} =>{5, -9, 8, 7} , кількість додатних чисел = 3  
//(фігурні дужки і коми, звісно, можна не виводити в консоль!!!)


int[] arrayElements = new int[10];
Random random = new Random();

for (int i = 0; i < arrayElements.Length; i++)
{
    arrayElements[i] = random.Next(-100, 100);
}

int count = 0;
foreach (int number in arrayElements)
{
    if (number > 0)
    {
        count++;
    }
}

Console.WriteLine("The array is:");
foreach (int number in arrayElements)
{
    Console.Write(number + " ");
}

Console.WriteLine("\nThe positive numbers in the array: " + count);