// проверка на некоректность ввода
int GetNumber(string message)
{
    bool isCorrect = false;
    int result = 0;

    while(!isCorrect)
    {
        Console.WriteLine(message);
        if(int.TryParse(Console.ReadLine(), out result))
        {
            return result;
        }
        else
            Console.WriteLine("Введите не число");
    }

    return result;
}




// квадрат числа
int number = GetNumber("Введите число");

int result = number * number;

Console.WriteLine($"Квадрат числа {number} = {result}");