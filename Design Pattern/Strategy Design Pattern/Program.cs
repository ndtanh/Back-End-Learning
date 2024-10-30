using Strategy_Design_Pattern;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 5, 2, 8, 1, 3 };

        SortStrategy context = new SortStrategy();

        // Using BubbleSort
        context.SetSortStrategy(new BubbleSort());
        context.Sort(numbers);
        Console.WriteLine(string.Join(", ", numbers)); // Output: 1, 2, 3, 5, 8

        // Reset list and use QuickSort
        numbers = new List<int> { 5, 2, 8, 1, 3 };
        context.SetSortStrategy(new QuickSort());
        context.Sort(numbers);
        Console.WriteLine(string.Join(", ", numbers)); // Output: 1, 2, 3, 5, 8
    }
}
