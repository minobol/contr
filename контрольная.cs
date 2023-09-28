using System;

class Program
{
    static void Main(string[] args)
    {
        string[] array = { "hello", "world", "this", "is", "a", "test" };
        string[] newArray = new string[array.Length];
        int count = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i].Length <= 3)
            {
                newArray[count] = array[i];
                count++;
            }
        }

        for (int i = 0; i < count; i++)
        {
            Console.WriteLine(newArray[i]);
        }
    }
}
