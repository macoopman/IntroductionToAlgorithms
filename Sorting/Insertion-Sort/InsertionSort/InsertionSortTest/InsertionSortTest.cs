using InsertionSort;

namespace InsertionSortTest
{
    [TestClass]
    public class InsertionSortTest
    {
        private InsertionSortBasic insertionSort;
        [TestInitialize]
        public void Setup()
        {
            insertionSort = new InsertionSortBasic();
        }
        [TestMethod]
        public void InsertionSort_Normal()
        {
            var b = new int[] { 5, 4, 3, 3, 2, 1 };
            var b_sorted = new int[] {1,2,3, 3,4,5};

            insertionSort.SortNonDecreasing(ref b);

            for (int i = 0; i < b_sorted.Length - 1; i++)
            {
                Assert.IsTrue(b[i] == b_sorted[i]);
            }
        }

        [TestMethod]
        public void InsertionSort_NonIncreasing1()
        {
            var b = new int[] { 5, 4};
            var b_sorted = new int[] { 5,4,};

            insertionSort.SortNonIncreasing(ref b);

            for (int i = 0; i < b_sorted.Length - 1; i++)
            {
                Assert.IsTrue(b[i] == b_sorted[i]);
            }
        }

        [TestMethod]
        public void InsertionSort_NonIncreasing2()
        {
            var b = new int[] { 4, 5 };
            var b_sorted = new int[] { 5, 4, };

            insertionSort.SortNonIncreasing(ref b);

            for (int i = 0; i < b_sorted.Length - 1; i++)
            {
                Assert.IsTrue(b[i] == b_sorted[i]);
            }
        }

        [TestMethod]
        public void InsertionSort_NonIncreasing3()
        {
            var b = new int[] { 4, 5, 6 };
            var b_sorted = new int[] { 6, 5, 4, };

            insertionSort.SortNonIncreasing(ref b);

            for (int i = 0; i < b_sorted.Length - 1; i++)
            {
                Assert.IsTrue(b[i] == b_sorted[i]);
            }
        }
    }
}