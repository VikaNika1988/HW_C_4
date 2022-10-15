// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Сумма цифр в числе {number} = {sumofdigits(number)}");

int sumofdigits(int num){
    int sum = 0;
    for (int i = 0; num > 0; i++)
    {
        i = num % 10;
        sum += i;
        num /= 10;      
    }
    return sum;
}
