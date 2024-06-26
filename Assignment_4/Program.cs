namespace Assignment_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Problem 17
            Console.WriteLine("Please Enter 3 points coordiantes");
            float[] xCoordinates = new float[3];
            float[] yCoordinates = new float[3];
            for (int i = 0; i < 3; i++)
            {
                Console.Write($"x{i + 1} = ");
                xCoordinates[i] = int.Parse(Console.ReadLine());

                Console.Write($"y{i + 1} = ");
                yCoordinates[i] = int.Parse(Console.ReadLine());
            }
            if (xCoordinates.Length == 0 || yCoordinates.Length == 0)
            {
                Console.WriteLine("No Coordinates were entered");
                return;
            }
            if ((xCoordinates[2] - xCoordinates[1]) * (yCoordinates[1] - yCoordinates[0]) ==
                (yCoordinates[2] - yCoordinates[1]) * (xCoordinates[1] - xCoordinates[0]))
                Console.WriteLine("The enterd points lie on a single straight line");
            else
                Console.WriteLine("The enterd points don't lie on a single straight line");
            #endregion
            #region Problem 18

            #endregion
            #region Problem 19

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