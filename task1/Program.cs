// Задача 19: Напишите программу, которая принимает на 
// вход пятизначное число и проверяет, является ли оно 
// палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да
Console.WriteLine("Please enter N");
int N = int.Parse(Console.ReadLine());
if (Math.Abs(N) < 9999) Console.WriteLine("Number is less than 10 000");
else
{
    int N5 = N % 10;
   
    int N1 = N / 10000;
        
    if (N1 == N5)
    {
        int N2 = N/1000-N1*10;
        
        int N4 = (N%100)/10;
                
        if (N2 == N4) Console.WriteLine($"Number {N} is palindrome");
        else 
        {
            Console.WriteLine($"Number {N} is not palindrome");
        }
    }
    else
    {
        Console.WriteLine($"Number {N} is not palindrome");
    }
}
