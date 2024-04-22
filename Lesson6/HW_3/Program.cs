// Потрібно додати до масиву елемент на початок. Нехай масив буде на 10 елементів.
// Масив заповнити рандомними числами. Той елемент, що потрібно додати, також взяти рандомно.

int[] oldArray = new int[10];
Random random = new Random();

for (int i = 0; i < oldArray.Length; i++)
{
    oldArray[i] = random.Next(-20, 20);
    Console.Write(oldArray[i] + " ");
}

int newElement = random.Next(21, 50);
Console.WriteLine($"\nThe new element is: {newElement}");

int[] newArray = new int[oldArray.Length + 1];
for (int i = 0; i < oldArray.Length; i++)
{
    newArray[i + 1] = oldArray[i];
}

newArray[0] = newElement;


foreach (int number in newArray)
{
    Console.WriteLine("The array with added a new element to the first position is:");
    Console.Write(number + " ");
}