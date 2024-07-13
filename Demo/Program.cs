using System.Text;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Control Statments
            #region If
            Console.Write("Enter a month number: ");
            int monthNUmber = int.Parse(Console.ReadLine());
            if (monthNUmber == 1)
                Console.WriteLine("The coresponding month is January");
            else if (monthNUmber == 2)
                Console.WriteLine("The coresponding month is Feburary");
            else if (monthNUmber == 3)
                Console.WriteLine("The coresponding month is March");
            else
                Console.WriteLine("The entered nummber is not in the first quarter");
            #endregion
            #region Switch
            switch (monthNUmber)
            {
                case 1:
                    Console.WriteLine("The coresponding month is January");
                    break;
                case 2:

                    Console.WriteLine("The coresponding month is Feburary");
                    break;
                case 3:
                    Console.WriteLine("The coresponding month is March");
                    break;
                default:
                    Console.WriteLine("The entered nummber is not in the first quarter");
                    break;
            }
            #endregion
            #endregion
            #region Loops
            int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
            #region for loop
            for (int i = 0; i < 20; i++)
                Console.WriteLine("**");

            for (int i = 0; i < arr.Length; i++)
                arr[i] += 1;
            #endregion
            #region foreach
            foreach (int item in arr)
                Console.Write($"{item}\t");
            Console.WriteLine();
            #endregion
            #region while
            int number = 3;
            while (number % 2 != 0)
            {
                Console.WriteLine($"{number} is not an even number");
                number++;
            }
            Console.WriteLine($"{number} is an even number");
            #endregion
            #region do while
            bool flag;
            int input;
            do
            {
                Console.Write("Enter an even number: ");
            } while (!int.TryParse(Console.ReadLine(), out input) || input % 2 != 0);
            Console.WriteLine($"Well done....{input} is an even number");
            #endregion
            #endregion
            #region String vs string builder
            string stringMessage = "message 1";
            Console.WriteLine(stringMessage);
            Console.WriteLine(stringMessage.GetHashCode());
            stringMessage += "....I have modified my string";
            Console.WriteLine(stringMessage);
            Console.WriteLine(stringMessage.GetHashCode());

            StringBuilder stringBuilder = new("Message 1 ");
            Console.WriteLine(stringBuilder);
            Console.WriteLine(stringBuilder.GetHashCode());
            Console.WriteLine(stringBuilder);
            stringBuilder.Append(".....I have modified my string");
            Console.WriteLine(stringBuilder.GetHashCode());
            #endregion
        }
    }
}