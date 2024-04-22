// Написати програму, яка виводить всі елементи масиву доки не зустрінеться елемент -1.
// Масив заповнити рандомними числами, діапазон чисел від -5 до 5. 

int[] array = new int[30];

Random rnd = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = rnd.Next(-5, 6);
}


foreach (int num in array)
{
    if (num != -1)
    {
        Console.Write(num + " ");
    }
    else
    {
        break;
    }
}