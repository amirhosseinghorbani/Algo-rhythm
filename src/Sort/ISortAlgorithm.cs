namespace Sort
{
    public interface ISortAlgorithm<T> where T : struct
    {
        T[] Sort(T[] list);
    }
}
