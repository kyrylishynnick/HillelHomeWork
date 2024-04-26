int subject = 3;

int[] makrs = new int[subject];
string[] subjects = { "Mathematics", "Literature", "History" };

for (int i = 0; i < subject; i++)
{
    Console.Write($"Input your mark for: '{subjects[i]}': ");
    if (int.TryParse(Console.ReadLine(), out int mark))
    {
        makrs[i] = mark;
    }
}

Console.WriteLine("Your marks are:");
for (int i = 0; i < subject; i++)
{
    Console.WriteLine($"{subjects[i]}: {makrs[i]}");
}

double avarageMark = GetCalculateAverage(makrs);

double GetCalculateAverage(int[] marks)
{
    double summ = 0;
    foreach (int mark in marks)
    {
        summ += mark;
    }

    return summ / marks.Length;
}

Console.WriteLine($"Avarage mark for all subects: {avarageMark}");