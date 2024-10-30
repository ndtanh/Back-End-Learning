namespace Strategy_Design_Pattern;

public class SortStrategy
{
    private ISortStrategy _sortStrategy;

    public void SetSortStrategy(ISortStrategy sortStrategy)
    {
        _sortStrategy = sortStrategy;
    }

    public void Sort(List<int> list)
    {
        _sortStrategy.Sort(list);
    }
}