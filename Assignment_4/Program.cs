namespace Assignment_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Problem 17
            //Console.WriteLine("Please Enter 3 points coordiantes");
            //float[] xCoordinates = new float[3];
            //float[] yCoordinates = new float[3];
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.Write($"x{i + 1} = ");
            //    xCoordinates[i] = int.Parse(Console.ReadLine());

            //    Console.Write($"y{i + 1} = ");
            //    yCoordinates[i] = int.Parse(Console.ReadLine());
            //}
            //if (xCoordinates.Length == 0 || yCoordinates.Length == 0)
            //{
            //    Console.WriteLine("No Coordinates were entered");
            //    return;
            //}
            //if ((xCoordinates[2] - xCoordinates[1]) * (yCoordinates[1] - yCoordinates[0]) ==
            //    (yCoordinates[2] - yCoordinates[1]) * (xCoordinates[1] - xCoordinates[0]))
            //    Console.WriteLine("The enterd points lie on a single straight line");
            //else
            //    Console.WriteLine("The enterd points don't lie on a single straight line");
            #endregion
            #region Problem 18
            //bool flag;
            //do
            //{
            //    Console.WriteLine("Please enter the worker's taken time to finish the task");
            //    float hours;
            //    flag = float.TryParse(Console.ReadLine(), out hours);
            //    switch (hours)
            //    {
            //        case float n when (n >= 2 && n < 3):
            //            Console.WriteLine("Worker is considered highly efficient.");
            //            break;
            //        case float n when (n >= 3 && n < 4):
            //            Console.WriteLine("Worker should increase his speed");
            //            break;
            //        case float n when (n >= 4 && n <= 5):
            //            Console.WriteLine("Worker should be provided with training to enhance their speed.");
            //            break;
            //        case float n when (n > 5):
            //            Console.WriteLine("Worker must leave the company");
            //            break;
            //        default:
            //            Console.WriteLine("Invalid Data");
            //            break;
            //    }
            //} while (!flag);
            #endregion
            #region Problem 19

            //bool flag;
            //int size;
            //do
            //{
            //    Console.Write("Enter the size of the matrix: ");
            //    flag = int.TryParse(Console.ReadLine(), out size);
            //} while (!flag);

            //byte[,] identityArray = new byte[size, size];
            //for (int i = 0; i < size; i++)
            //{
            //    for (int j = 0; j < size; j++)
            //    {
            //        if (i == j)
            //            identityArray[i, j] = 1;
            //        else
            //            identityArray[i, j] = 0;
            //    }
            //}
            //int rows = identityArray.GetLength(0);
            //int columns = identityArray.GetLength(1);

            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < columns; j++)
            //        Console.Write($"{identityArray[i, j]}    ");

            //    Console.WriteLine();
            //}

            ////Another solution without using array
            //for (int i = 0; i < size; i++)
            //{
            //    for (int j = 0; j < size; j++)
            //    {
            //        if (i == j)
            //            Console.Write("1    ");
            //        else
            //            Console.Write("0    ");
            //    }
            //    Console.WriteLine();
            //}
            #endregion
            #region Problem 20
            ////Assume the array is 1d
            //int[] numbers = { 1, 2, 4, 9, 10, 50, 30 };
            //int result = 0;
            //foreach (int number in numbers)
            //    result += number;
            //Console.WriteLine($"The final result is {result}");
            #endregion
            #region Problem 21
            //int[] array1 = { 10, 40, 80, 150 };
            //int[] array2 = { 200, 30, 20, 70 };
            //if (array1.Length != array2.Length)
            //{
            //    Console.WriteLine("The arrays are not the same size");
            //    return;
            //}
            //int[] result = new int[array1.Length + array2.Length];
            //int i = 0, j = 0, k = 0;
            ////Merge two arrays first
            //while (i < array1.Length)
            //{
            //    result[k] = array1[i];
            //    i++;
            //    k++;
            //}

            //while (j < array2.Length)
            //{
            //    result[k] = array2[j];
            //    j++;
            //    k++;
            //}
            //Quick_Sort(result, 0, result.Length - 1);
            //Console.WriteLine("Sorted array : ");

            //foreach (var number in result)
            //{
            //    Console.Write(" " + number);
            //}
            //// Using Quick sort algorithm to sort the array
            //static void Quick_Sort(int[] arr, int left, int right)
            //{
            //    if (left < right)
            //    {
            //        int pivot = Partition(arr, left, right);

            //        if (pivot > 1)
            //            Quick_Sort(arr, left, pivot - 1);

            //        if (pivot + 1 < right)
            //            Quick_Sort(arr, pivot + 1, right);
            //    }
            //}
            //static int Partition(int[] arr, int left, int right)
            //{
            //    int pivot = arr[left];
            //    while (true)
            //    {
            //        while (arr[left] < pivot)
            //            left++;

            //        while (arr[right] > pivot)
            //            right--;

            //        if (left < right)
            //        {
            //            if (arr[left] == arr[right]) return right;

            //            int temp = arr[left];
            //            arr[left] = arr[right];
            //            arr[right] = temp;
            //        }
            //        else
            //            return right;
            //    }
            //}
            #endregion
            #region Problem 22
            ////Assume array is 1d
            //int[] array = {5,2,7,7,5,5,2 };
            //List<int> checkedNumbers = new();
            //int i, j, count;
            //for (i = 0; i < array.Length; i++)
            //{
            //    if (checkedNumbers.Contains(array[i]))
            //        continue;
            //    count = 1;
            //    for (j = i + 1; j < array.Length; j++)
            //    {
            //        if (array[i] == array[j])
            //        {
            //            count++;
            //        }
            //    }
            //    checkedNumbers.Add(array[i]);
            //    Console.WriteLine($"Number {array[i]} appears {count} times");
            //}
            #endregion
            #region Problem 23
            //int[] array = { 1, 5, 6, 9, 87, 10, 30, -1, 13656 };
            //int max = array[0], min = array[0], i;
            //for (i = 1; i < array.Length; i++)
            //{
            //    if (array[i] > max)
            //        max = array[i];

            //    if (array[i] < min)
            //        min = array[i];
            //}
            //Console.WriteLine($"Max number: {max}");
            //Console.WriteLine($"Min number: {min}");
            #endregion
            #region Problem 24
            //int[] array = { 1, 5, 6, 9, 87, 90, 10, 30, -1, 13656 };
            //int i, j, max1 = array[0], max2 = array[0];
            //for (i = 1; i < array.Length; i++)
            //{
            //    if (array[i] > max1)
            //        max1 = array[i];
            //}
            //for (j = 1; j < array.Length; j++)
            //{
            //    if (array[j] > max2)
            //    {
            //        if (array[j] == max1)
            //            continue;
            //        max2 = array[j];
            //    }
            //}
            //Console.WriteLine($"Second Largest is : {max2}");
            #endregion
            #region Problem 25
            //int[] array = { 1, 2, 3, 4, 2, 5, 6, 7, 8, 1 };
            //int maxDistance = 0;
            //for (int i = 0; i < array.Length; i++)
            //{
            //    for (int j = i + 1; j < array.Length; j++)
            //    {
            //        if (array[i] == array[j])
            //        {
            //            int distance = j - i - 1;
            //            if (distance > maxDistance)
            //            {
            //                maxDistance = distance;
            //            }
            //        }
            //    }
            //}
            //Console.WriteLine($"The longest distance between two equal cells is: {maxDistance}");
            #endregion
            #region Problem 26
            //Console.Write("Enter a sentence:");
            //string input = Console.ReadLine();
            //string[] partitions = input.Split(" ");
            //for (int i = partitions.Length - 1; i >= 0; i--)
            //{
            //    Console.Write(partitions[i]+" "); 
            //}
            #endregion
            #region Problem 27
            //int rows, cols;

            //Console.Write("Enter size of rows: ");
            //int.TryParse(Console.ReadLine(), out rows);

            //Console.Write("Enter size of columns: ");
            //int.TryParse(Console.ReadLine(), out cols);

            //int[,] firstArray = new int[rows, cols];
            //int[,] secondArray = new int[rows, cols];

            //Console.WriteLine("Enter the elements of the first array:");
            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < cols; j++)
            //    {
            //        Console.Write($"Element [{i},{j}]: ");
            //        firstArray[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}

            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < cols; j++)
            //        secondArray[i, j] = firstArray[i, j];
            //}

            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < cols; j++)
            //        Console.Write($"{secondArray[i, j]}\t");

            //    Console.WriteLine();
            //}
            #endregion
            #region Problem 28
            //int[] array = { 100, 50, 98, 21, 54, 74, 10, 25 };
            //int i;
            //for (i = array.Length - 1; i >= 0; i--)
            //{
            //    Console.Write($"{array[i]}   ");
            //}
            #endregion
        }
    }
}