// See https://aka.ms/new-console-template for more information
int x1, x2, y1, y2;
double length;
Console.WriteLine("-----------Calculate the Length Of Line-------------");
Console.WriteLine("Enter x1 Value");
x1=Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter y1 Value");
y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter x2 Value");
x2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter y2 Value");
y2 = Convert.ToInt32(Console.ReadLine());

length = Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y1-y1,2));
Console.WriteLine("Length of Line is : " + length);