namespace _4._Reverse_Array_of_Strings;
class Program
{
    static void Main(string[] args)
    {
        string[] arrayInput = Console.ReadLine().Split(' ');

        for (int i = 0; i < arrayInput.Length; i++)
        {
            Console.Write(arrayInput[arrayInput.Length - 1 - i] + " ");
        }
    }
}

