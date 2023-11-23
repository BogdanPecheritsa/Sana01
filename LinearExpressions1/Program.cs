using System.Text;

double a, b, c, d, x, y, z, r;
Console.OutputEncoding = Encoding.Unicode;
Console.InputEncoding = Encoding.Unicode;

Console.WriteLine("Задайте значення а:");
a = double.Parse(Console.ReadLine());
Console.WriteLine("Задайте значення b:");
b = double.Parse(Console.ReadLine());
Console.WriteLine("Задайте значення c:");
c = double.Parse(Console.ReadLine());
Console.WriteLine("Задайте значення d:");
d = double.Parse(Console.ReadLine());

x = (a + 2 * b - c + d) / (c * d) + (a + b) / (c - d) - a * a / (b * b);
Console.WriteLine($"x: {x}");

y = 5 * (a + b) * (c - d) / 0.5 * c + d * d * ((a * a - b * b) / (b - a));
Console.WriteLine($"y: {y}");

z = (Math.Pow(x * x - 2 * x, 3) - 4 * (Math.Pow(x, 4) + 1)) * (1 - b) / (5 * a + 3 * b);
Console.WriteLine($"z: {z}");

r = (1.0 / 2 * a + 3.0 / 4 * b - 7.0 / 5) / (3 * c + 1) + 1 / (a - c);
Console.WriteLine($"r: {r}");