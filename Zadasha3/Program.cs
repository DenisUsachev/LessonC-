Console.WriteLine("Введите какой день недели");
string input0 = Console.ReadLine();
int num0 = Convert.ToInt32(input0);

if (num0 == 1)
{
    Console.WriteLine("Сегодня понедельник!");
}
if (num0 == 2)
{
    Console.WriteLine("Сегодня Вторник!");
}
if (num0 == 3)
{
    Console.WriteLine("Сегодня Среда!");
}
if (num0 == 4)
{
    Console.WriteLine("Сегодня Четверг!");
}
if (num0 == 5)
{
    Console.WriteLine("Сегодня Пятница!");
}
if (num0 == 6)
{
    Console.WriteLine("Сегодня Суббота!");
}
if (num0 == 7)
{
    Console.WriteLine("Сегодня Воскресенье!");
}