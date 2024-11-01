
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter array size: ");
        int size = int.Parse(Console.ReadLine());
        int[] array = new int[size];

        for (int i = 0; i < size; i++)
        {
            Console.WriteLine($"Enter an integer {i + 1}: ");
            array[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Enter index (0 to " + (size - 1) + "): ");
        int index = int.Parse(Console.ReadLine());

        Console.WriteLine("Result: " + SumNumber(array[index]));
    }

    static int SumNumber(int num)
    {
        int sum = 0;
        while (num > 0)
        {
            sum += num % 10;
            num /= 10;
        }
        return sum;
    }
}
