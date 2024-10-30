namespace Strategy_Design_Pattern;

public class QuickSort : ISortStrategy
{
    public void Sort(List<int> list)
    {
        Console.WriteLine("Sorting using quick sort");
    }
}