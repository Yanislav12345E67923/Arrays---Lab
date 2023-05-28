namespace _07._Equal_Arrays;
class Program
{
    static void Main(string[] args)
    {
        int[] inputOne = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int[] inputTwo = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        bool notEqual = false;
        if (inputOne.Length > inputTwo.Length)
            for (int i = 0; i < inputOne.Length; i++)
            {
                if (inputOne[i] != inputTwo[i])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    notEqual = true;
                    break;
                }
            }
        else
        {
            for (int i = 0; i < inputTwo.Length; i++)
            {
                if (inputOne[i] != inputTwo[i])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    notEqual = true;
                    break;
                }
            }
        }

        
        if (!notEqual)
        {
            Console.WriteLine($"Arrays are identical. Sum: {inputOne.Sum()}");
        }
    }
}

