System.Console.Write("Введите число:    ");
string writeNum = Console.ReadLine();
int num = Convert.ToInt32(writeNum);
string result = $"{num} является чётным";

if (num % 2 != 0) result = result.Replace("является", "не является");

System.Console.WriteLine(result);