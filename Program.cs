// Just a noob quadratic formula calculator, literally my first time writing something proper in C#

Console.WriteLine("Enter coefficients a b and c: ");
double a = double.Parse(Console.ReadLine());
double b = double.Parse(Console.ReadLine());
double c = double.Parse(Console.ReadLine());

double D = (b * b) - (4 * a * c);
Console.WriteLine($"D = {D}");

if (D < 0)
{
    Console.WriteLine("No real solutions, I'm too lazy to code those");
}
else if (D == 0)
{
    double x0 = -b / (2 * a);
    Console.WriteLine($"Only one solution: {x0}");
}
else
{
    double sqrt_D = Math.Sqrt(D);
    double x1 = (-b - sqrt_D) / (2 * a);
    double x2 = (-b + sqrt_D) / (2 * a);
    Console.WriteLine($"Two solutions:\nx1 = {x1}\nx2 = {x2}");
}