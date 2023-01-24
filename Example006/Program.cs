/*посчитать сумму чисел от 1 до указанного числа*/


int GetNumber(string message)
{
    int result = 0;

    while(true)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result) && result > 1)
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число. Повторите ввод");
        }
    }

    return result;
}

int GetSumm(int number)
{
    int sum = 0;

    for (int i = 1; i <= number; i++)
    {
        sum += i;
    }

    return sum;
}

int number = GetNumber("Введите число больше 1");
int sum = GetSumm(number);
Console.WriteLine($"сумма чисел от 1 до {number} = {sum}");
