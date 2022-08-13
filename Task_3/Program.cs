//Задача 23

//Напишите программу, которая принимает на вход число (N) 
//и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

void Cube(int num)

{
    Console.Write($"{num} -> ");
    int index = 1;
    while(index < num)
    {
        Console.Write($"{Math.Pow(index, 3)}, ");
        index++;
    }
    Console.Write(Math.Pow(num, 3));
    Console.WriteLine();
}

Cube(3);
Cube(5);
Cube(9);