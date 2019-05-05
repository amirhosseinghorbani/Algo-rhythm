namespace Sort.Concrete
{
    public class InsertionSort<T> : ISortAlgorithm<T> where T : struct
    {
        public T[] Sort(T[] list)
        {
            for(int j = 1; j < list.Length; j++)
            {
                T key = list[j];
                int i = j - 1;
                while((i >= 0) && ((dynamic)list[i] > (dynamic)key))
                {
                    list[i + 1] = list[i];
                    i--;
                }
                list[i + 1] = key;
            }
            return list;
        }
    }
}