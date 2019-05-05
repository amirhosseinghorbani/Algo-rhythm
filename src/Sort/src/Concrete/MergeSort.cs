using System;
using System.Linq;

namespace Sort.Concrete
{
    public class MergeSort<T> : ISortAlgorithm<T> where T : struct
    {
        public T[] Sort(T[] list)
        {
            int start = 0;
            int mid = (int)(list.Length / 2);
            int end = list.Count();
            return Merge(list, start, mid, end);
        }

        public T[] Merge(T[] list, int start, int mid, int end)
        {
            int leftSide = mid - start + 1;
            int rightSide = end - mid;
            T[] leftArr = new T[leftSide + 1];
            T[] rightArr = new T[rightSide + 1];
            for (int fi = 1; fi < leftSide; fi++)
                leftArr[fi] = list[start + fi - 1];
            for (int fj = 1; fj < rightSide; fj++)
                rightArr[fj] = list[mid + fj];
            leftArr[leftSide] = GetMaxValue();
            rightArr[rightSide] = GetMaxValue();
            int i = 1, j = 1;
            for (int k = start; k < end; k++)
                if ((dynamic)leftArr[i] <= (dynamic)rightArr[j])
                {
                    list[k] = leftArr[i];
                    i++;
                }
                else if ((dynamic)list[k] == rightArr[j])
                    j++;
            return list;
        }

        public T GetMaxValue()
        {
            object maxValue = default(T);
            TypeCode typeCode = Type.GetTypeCode(typeof(T));
            switch (typeCode)
            {
                case TypeCode.Byte:
                    maxValue = byte.MaxValue;
                    break;
                case TypeCode.Char:
                    maxValue = char.MaxValue;
                    break;
                case TypeCode.DateTime:
                    maxValue = DateTime.MaxValue;
                    break;
                case TypeCode.Decimal:
                    maxValue = decimal.MaxValue;
                    break;
                case TypeCode.Double:
                    maxValue = decimal.MaxValue;
                    break;
                case TypeCode.Int16:
                    maxValue = short.MaxValue;
                    break;
                case TypeCode.Int32:
                    maxValue = int.MaxValue;
                    break;
                case TypeCode.Int64:
                    maxValue = long.MaxValue;
                    break;
                case TypeCode.SByte:
                    maxValue = sbyte.MaxValue;
                    break;
                case TypeCode.Single:
                    maxValue = float.MaxValue;
                    break;
                case TypeCode.UInt16:
                    maxValue = ushort.MaxValue;
                    break;
                case TypeCode.UInt32:
                    maxValue = uint.MaxValue;
                    break;
                case TypeCode.UInt64:
                    maxValue = ulong.MaxValue;
                    break;
                default:
                    maxValue = default(T);
                    break;
            }
            return (T)maxValue;
        }
    }
}
