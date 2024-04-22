//Написати програму для інверсії масиву, тобто перевороту його у зворотному порядку.
//В цьому завданні недостатньо просто вивести елементи масиву у зворотному порядку. 
// Ідеально написати 2 способами (*вища оцінка буде) - через новий масив та переписавши значення заданного масиву. 
// {5, -9, 8, 7} => {7, 8, -9, 5}

class Program
{
    static void Main()
    {
        int[] array = { 5, -9, 8, 7 };


        int[] reservedArray = new int[array.Length];
        for (int i = 0; i < array.Length; i++)
        {
            reservedArray[i] = array[array.Length - 1 - i];
        }


        for (int i = 0; i < array.Length / 2; i++)
        {
            int newTempArray = array[i];
            array[i] = array[array.Length - 1 - i];
            array[array.Length - 1 - i] = newTempArray;
        }

        Console.WriteLine("The first variant:");
        PrintArray(reservedArray);

        Console.WriteLine("\nThe second variant:");
        PrintArray(array);
    }

    static void PrintArray(int[] array)
    {
        foreach (var item in array)
        {
            Console.Write(item + " ");
        }

        Console.WriteLine();
    }
}