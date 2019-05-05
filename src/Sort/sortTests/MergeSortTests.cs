using Sort.Concrete;
using System.Diagnostics;
using Xunit;

namespace sortTests
{
    public class MergeSortTests
    {
        [Fact]
        public void SortInteger_NotSorted_Correct()
        {
            int[] arr = { 54, 23, 543, 192, 352, 53 };
            int[] sortArr = { 23, 53, 54, 192, 352, 543 };
            var sortAlgorithm = new MergeSort<int>();
            int[] resultArr = sortAlgorithm.Sort(sortArr);
            Assert.Equal(sortArr, resultArr);
        }

        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 })]
        public void SortInteger_AlreadySort_Correct(int[] arr)
        {
            var sortAlgorithm = new MergeSort<int>();
            int[] resultArr = sortAlgorithm.Sort(arr);
            Assert.Equal(arr, resultArr);
        }

        [Fact]
        public void SortInteger_NotSorted_LegalElapseTime()
        {
            var sortAlgorithm = new MergeSort<int>();
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            sortAlgorithm.Sort(DataTest.hundredIntNumber);
            stopWatch.Stop();
            Assert.True(stopWatch.ElapsedMilliseconds < 100,
                $"Elapsed in seconds {stopWatch.Elapsed.Seconds} is ok");
        }
    }
}
