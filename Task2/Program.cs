// Задача №2: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

int DefAckermann(int num1, int num2)
{
    if(num1 == 0) return num2 + 1;
    else if (num2 == 0) return DefAckermann(num1 - 1, 1);
    else return DefAckermann(num1 - 1, DefAckermann(num1, num2 -1));
}

Console.WriteLine("Введите первое число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int m = Convert.ToInt32(Console.ReadLine());
int result = DefAckermann(n, m);
Console.WriteLine($"{result}");
// Console.WriteLine(DefAckermann(n, m));
