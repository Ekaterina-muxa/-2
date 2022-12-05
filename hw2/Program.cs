/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

17 -> такого числа в массиве нет
*/


int[] CreateArray (int size)
{
    int [] newArray = new int [size];
    for(int i=0; i < size; i++)
    {
      Console.WriteLine ($"введите элемент {i}");
      newArray[i] = Convert.ToInt32(Console.ReadLine());
    }
    return newArray;
}

void ShowArray (int[] array)
{
    Console.Write ("получившийся массив - >");
    for (int i=0; i< array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }

}

void number1(int[] array)
{
    Console.WriteLine ($"введите номер элемента");
    int number = Convert.ToInt32(Console.ReadLine());
    for (int i = 0; i< array.Length; i++)
    {
        if (number == (i)) 
        {
            Console.WriteLine ($"элемент под данным номером равен - > ", array[i]);
        }
        else 
        {
            Console.WriteLine ($" такого элемента нет"); 
        }

    }
    
}


Console.Write($"введите размер массива");
int a = Convert.ToInt32(Console.ReadLine());
int [] myArray = CreateArray (a);
ShowArray(myArray);
number1(myArray);
