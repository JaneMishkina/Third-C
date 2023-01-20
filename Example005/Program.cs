//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел 
//от 1 до N.

//5 -> 1, 4, 9, 16, 25.
//2 -> 1,4

int GetNumber()
{ 
Console.WriteLine("Введите число");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int N = GetNumber();
int i = 1;

while ( i < N)

{

Console.Write(i*i + ",");
i+=1;
}
Console.Write(i*i + ".");