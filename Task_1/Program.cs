// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Console.WriteLine("Введите первое число: ");
int A = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число:");
int B = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Число {A} в натуральной степени {B} = {degree(A,B)}");

int degree (int A, int B){
    int res = A;
    for (int i = 1; i < B; i++)
    {
        res *= A;   
    }
    return res;
}
