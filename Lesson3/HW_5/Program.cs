//Користувач вводить радіус круга. Напишіть програму, яка обчислює площу цього круга і виводить в консоль результат. 

Console.WriteLine("Inpur please a radius:");
int radius = int.Parse(Console.ReadLine());

Console.WriteLine("The area of a circle  = " + Math.PI * Math.Pow(radius, 2));
