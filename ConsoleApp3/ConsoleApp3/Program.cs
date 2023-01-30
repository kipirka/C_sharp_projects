// See https://aka.ms/new-console-template for more information
using System.Text;
Console.OutputEncoding = Encoding.Unicode;
Console.InputEncoding = Encoding.Unicode;

Console.WriteLine("Введите год");
int year = Convert.ToInt16(Console.ReadLine());

if ((year % 4 == 0) && (year % 100 != 0) || (year % 400 == 0))
{
    Console.WriteLine("год високосный");
}
   
else
{
    Console.WriteLine("год невисокосный");
}

