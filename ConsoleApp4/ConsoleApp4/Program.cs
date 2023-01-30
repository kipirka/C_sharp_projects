// See https://aka.ms/new-console-template for more information
using System.Text;

Console.OutputEncoding = Encoding.Unicode;
Console.InputEncoding= Encoding.Unicode;

//Используйте все отношения к числам и выведите значение true

int x = 2;
int y = 4;

bool z = (x + y > x - y) || (x * y < x / y);
Console.WriteLine(z);