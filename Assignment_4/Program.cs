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

            #endregion
            #region Problem 21

            #endregion
            #region Problem 22

            #endregion
            #region Problem 23

            #endregion
            #region Problem 24

            #endregion
            #region Problem 25

            #endregion
            #region Problem 26

            #endregion
            #region Problem 27

            #endregion
            #region Problem 28

            #endregion
        }
    }
}