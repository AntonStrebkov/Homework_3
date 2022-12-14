//Задача 19

//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

void Palindrome(int num)
{
    int digit5 = num % 10;
    int digit4 = num/10 % 10;
    int digit3 = num/100 % 10;
    int digit2 = num/1000 % 10;
    int digit1 = num/10000;
    
    if(digit1 == digit5 && digit2 == digit4)
        Console.WriteLine($"{num} -> да");
    else
        Console.WriteLine($"{num} -> нет");
}

Palindrome(14212);
Palindrome(12821);
Palindrome(23432);