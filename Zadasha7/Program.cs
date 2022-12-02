Console.WriteLine("Введите трёхзначное число ");
string num0 = Console.ReadLine()??"";
int number = int.TryParse(number, out int n);
if((number > 99) && (number <= 999))
{
    Console.Write(number % 10);
}
else
    Console.Write("Неверно введенное число");
