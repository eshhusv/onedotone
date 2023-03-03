Console.Write("Введите а: ");
double a = double.Parse(Console.ReadLine());
Console.Write("Введите b: ");
double b = double.Parse(Console.ReadLine());
Console.Write("Введите c: ");
double c = double.Parse(Console.ReadLine());
Console.WriteLine($"Ответ: {((b + Math.Sqrt(Math.Pow(b, 2) + 4 * a * c))/(2 * a)) - Math.Pow(a, 3) * c + Math.Pow(b, -2)}");