using System.Text;

double a, b, m, n, x, y, z1, z2;
Console.OutputEncoding = Encoding.Unicode;
Console.InputEncoding = Encoding.Unicode;

Console.WriteLine("Значення а:");
a = double.Parse(Console.ReadLine());

Console.WriteLine("Значення b:");
b = double.Parse(Console.ReadLine());

Console.WriteLine("Значення m:");
m = double.Parse(Console.ReadLine());

Console.WriteLine("Значення n:");
n = double.Parse(Console.ReadLine());

Console.WriteLine("Значення x:");
x = double.Parse(Console.ReadLine());

z1 = ((m - 1) * Math.Sqrt(m) - (n - 1) * Math.Sqrt(n)) / (Math.Sqrt(m * m * m * n) + n * m + m * m - m);
Console.WriteLine($"z1 = {z1}");

z2 = (Math.Sqrt(m) - Math.Sqrt(n)) / m;
Console.WriteLine($"z2 = {z2}");

y = 2.4 * Math.Abs((x * x + b) / a) + (a - b) * Math.Sin(a - b) * Math.Sin(a - b) + Math.Pow(10, -2) * (x - b);
Console.WriteLine($"y = {y}");