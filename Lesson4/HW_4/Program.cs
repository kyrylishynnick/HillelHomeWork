//a * x^2 + b * x + c = 0
// D = b^2 - 4 * a * c 

Random random = new Random();
double a = random.Next();
double b = random.Next();
double c = random.Next();

double x1, x2;

double discriminant = Math.Pow(b, 2) - 4 * a * c;
if (discriminant < 0)
{
    Console.WriteLine("The equation has no roots.");
}
else
{
    if (discriminant == 0)
    {
        x1 = -b / (2 * a);
        x2 = x1;
        Console.WriteLine("The equation has one root.");
    }
    else
    {
        x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
        x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
    }

    Console.WriteLine($"The equation has two roots x1 = {x1}; x2 = {x2}");
}