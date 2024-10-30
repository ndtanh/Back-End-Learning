namespace Strategy_Design_Pattern;

public class BubbleSort : ISortStrategy
{
    public void Sort(List<int> list)
    {
        Console.WriteLine("Sorting using bubble sort");
    }
}