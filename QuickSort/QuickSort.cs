namespace QS
{
    public class QuickSort
    {
        public static void Main()
        {
            var arr = new int[] { 4, 19, 8, 37, 1, 93, 67, 123, 22, 20 };
            Console.WriteLine("Arr after sort:");
            QuickSortFunc(arr);

            foreach (int i in arr)
            {
                Console.Write($"{i}, ");
            }
        }

        public static void QuickSortFunc(int[] arr)
        {
            Partition(arr, 0, arr.Length - 1);
        }

        private static void Partition(int[] arr, int low, int high)
        {
            int partitionIndex = high;
            int swap = low, comparator = low;
            Console.WriteLine($"Low: {low}, High: {high}");
            int temp;
            for (;comparator < partitionIndex; comparator++)
            {
                if (arr[comparator] < arr[partitionIndex])
                {
                    temp = arr[swap];
                    arr[swap] = arr[comparator];
                    arr[comparator] = temp;
                    swap++;
                }
            }

            temp = arr[swap];
            arr[swap] = arr[partitionIndex];
            arr[partitionIndex] = temp;

            if (low < swap - 1)
            {
                Partition(arr, low, swap - 1);
            }

            if (swap + 1 < high)
            {
                Partition(arr, swap + 1, high);
            }
        }
    }
}
