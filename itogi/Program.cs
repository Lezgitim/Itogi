void PrintMassiv (string [] array)
{
    
    for(int i = 0; i < array.Length; i++)
    {
       if(array[i].Length <= 3) Console.Write (array[i] + " ");
    }
    Console.WriteLine();
} 
string [] array