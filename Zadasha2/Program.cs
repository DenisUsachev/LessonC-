Console.WriteLine("Введите квадрат числа ");
string input0 = Console.ReadLine();
Console.WriteLine("Введите число");
string input1 = Console.ReadLine();
int num0 = Convert.ToInt32(input0);
int num1 = Convert.ToInt32(input1);

if ((num1 * num1) == num0 )
{
    Console.WriteLine($"Число {num1} является квадратом корня {num0}");
}
else
{
    Console.WriteLine($"Число {num1} не является квадратом корня {num0}");
}