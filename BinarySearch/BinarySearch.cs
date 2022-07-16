
namespace BS {

    public class BinarySearch {

        public static void Main(string[] args) {
            Console.WriteLine("Binary Search algorythm");

            var arr = new int[] { 1, 3, 6, 17, 32, 41, 53, 57, 58, 68, 70, 73 };
            Console.WriteLine(arr);

            int numberToFind = 17;
            int index = binarySearch(arr, numberToFind);
            Console.WriteLine($"Found number {numberToFind} at index {index}");

            numberToFind = 32;
            index = binarySearch(arr, numberToFind);
            Console.WriteLine($"Found number {numberToFind} at index {index}");

            numberToFind = 73;
            index = binarySearch(arr, numberToFind);
            Console.WriteLine($"Found number {numberToFind} at index {index}");

            numberToFind = 8;
            index = binarySearch(arr, numberToFind);
            Console.WriteLine($"Found number {numberToFind} at index {index}");
            Console.ReadKey();
        }


        private static int binarySearch(int[] arr, int number) {
            int low = 0, high = arr.Length;
            int middle = high / 2;

            while (low <= high) {
                if (arr[middle] == number)
                return middle;

                if (arr[middle] > number)
                high = middle - 1;
                else
                low = middle + 1;

                middle = (low + high) / 2;
            }

            return -1;
        }
    }
}
