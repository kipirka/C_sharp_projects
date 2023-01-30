// See https://aka.ms/new-console-template for more information
using System.Text;
Console.OutputEncoding = Encoding.Unicode;
Console.InputEncoding = Encoding.Unicode;

bool a = true;
bool b = false;
Console.WriteLine((a && b) || (!a && !b));
