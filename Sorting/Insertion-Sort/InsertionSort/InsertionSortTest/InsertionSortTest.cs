using InsertionSort;

namespace InsertionSortTest
{
    [TestClass]
    public class InsertionSortTest
    {
        [TestMethod]
        public void InsertionSort_sdf()
        {
            InsertionSortBasic ddd = new InsertionSortBasic();

            var b = new int[] { 5, 4, 3, 3, 2, 1 };
            var b_sorted = new int[] {1,2,3,4,5,6};

            ddd.Sort(ref b);


        }
    }
}