Console.WriteLine("\n========= SIMPLE CALCULATOR =========\n");

Console.Write("Enter First Number: ");
double firstnum = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter Second Number: ");
double secondnum = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"\n{firstnum} + {secondnum} = {firstnum + secondnum}");
Console.WriteLine($"{firstnum} - {secondnum} = {firstnum - secondnum}");
Console.WriteLine($"{firstnum} * {secondnum} = {firstnum * secondnum}");
Console.WriteLine($"{firstnum} / {secondnum} = {firstnum / secondnum}");

Console.WriteLine("\n======================================");
