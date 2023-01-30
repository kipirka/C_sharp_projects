// See https://aka.ms/new-console-template for more information
using System.Text;
Console.OutputEncoding = Encoding.Unicode;
Console.InputEncoding = Encoding.Unicode;

//bool a = true;
//bool b = false;
//Console.WriteLine((a && b) || (!a && !b));

int x = 5;
int y = 10;
bool z = (y > Math.Pow(x,2) || y >= 2*x && x < y);
Console.WriteLine(z);