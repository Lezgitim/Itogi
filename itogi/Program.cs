// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.

void PrintMassiv (string [] array)
{
    
    for(int i = 0; i < array.Length; i++)
    {
       if(array[i].Length <= 3) Console.Write (array[i] + " ");
    }
    Console.WriteLine();
} 

string [] array = new string [] {"улы", "бка", "здесь", ":)"};
PrintMassiv(array);
