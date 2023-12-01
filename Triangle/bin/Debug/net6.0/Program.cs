// See https://aka.ms/new-console-template for more information
using Triangle;

Random rnd = new Random();
TriangleT tr = new TriangleT();

for (int i = 1; i < 30; i++)
{
    
    
    double a = rnd.Next();
    double b = rnd.Next();
    double c = rnd.Next();

    Console.WriteLine($"{a} {b} {c}");
    Console.WriteLine(tr.triangleType(a,b,c));
    
}
Console.ReadLine();

