// Створіть програму, яка дозволяє вводити оцінки студента з різних предметів та обчислювати середню оцінку. Використовуйте масиви для зберігання оцінок. 
// Завдання повинно включати такі пункти:
// Введення оцінок студента з різних предметів (наприклад, математика, історія, мова).
// Збереження цих оцінок у масивах.
// Обчислення середньої оцінки студента на основі введених даних.
// Виведення середньої оцінки на екран.
// Виведення оцінок. 
// Масиви використовуються для зберігання оцінок студента, і програма має виводити результат в консоль.

int amountOfSubject = 3;
int amountOfMarks = 3;

int[,] marks = new int[amountOfSubject, amountOfMarks];

string[] subjects = { "Mathematics", "Literature", "History" };

for (int indexOfSubject = 0; indexOfSubject < amountOfSubject; indexOfSubject++)
{
    Console.WriteLine($"Input yor mark for {subjects[indexOfSubject]}:");
    for (int indexOfMarks = 0; indexOfMarks < amountOfMarks; indexOfMarks++)
    {
        Console.Write($"The mark is {indexOfMarks + 1}: ");
        if (!int.TryParse(Console.ReadLine(), out marks[indexOfSubject, indexOfMarks]))
        {
        }
    }
}

double[] averageGrades = new double[amountOfSubject];
for (int subjectIndex = 0; subjectIndex < amountOfSubject; subjectIndex++)
{
    double total = 0;
    for (int gradeIndex = 0; gradeIndex < amountOfMarks; gradeIndex++)
    {
        total += marks[subjectIndex, gradeIndex];
    }

    averageGrades[subjectIndex] = total / amountOfMarks;
}

Console.WriteLine("The avarage marks are:");
for (int subjectIndex = 0; subjectIndex < amountOfSubject; subjectIndex++)
{
    Console.WriteLine($"{subjects[subjectIndex]}: {averageGrades[subjectIndex]}");
}