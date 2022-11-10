using System;
using static System.Console;

string[] array = AskArray();
string[] arraynew = new string[array.Length];
CreateNewArray(array, arraynew);
PrintArray(arraynew);

string[] AskArray()
    {
        Write("Введите значения через пробел: ");
        return ReadLine().Split(" ");
    }

    void CreateNewArray(string[] array, string[] arraynew)
    {
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i].Length <= 3)
            {
                arraynew[count] = array[i];
                count++;
            }
        }

    }

    void PrintArray(string[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"{array[i]} ");
        }
        Console.WriteLine();
    }
   
