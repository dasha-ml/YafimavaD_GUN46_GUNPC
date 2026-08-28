namespace ArraysHomework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Здесь массивы заданий 1-4

            int[] arrayFibo = new int[8];
            arrayFibo[0] = 0;
            arrayFibo[1] = 1;
            for (int j = 2; j < arrayFibo.Length; j++)
            {
                arrayFibo[j] = arrayFibo[j - 1] + arrayFibo[j - 2];
            }

            string[] arrayMonth = new string[12] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };

            int[,] arrayTable = new int[3, 3];
            int[] baseNumbers = new int[3] { 2, 3, 4 };
            for (int i = 0; i < arrayTable.GetLength(0); i++)
            {
                for (int j = 0; j < arrayTable.GetLength(1); j++)
                {
                    arrayTable[i, j] = (int)Math.Pow(baseNumbers[j], i + 1);
                }
            }

            double[][] arrayJagged = new double[3][];
            arrayJagged[0] = new double[5];
            arrayJagged[1] = new double[2] { Math.E, Math.PI };
            arrayJagged[2] = new double[4];
            for (int i = 0; i < arrayJagged[0].Length; i++)
            {
                arrayJagged[0][i] = i + 1;
            }
            double num = 1;
            for (int i = 0; i < arrayJagged[2].Length; i++)
            {
                arrayJagged[2][i] = Math.Log10(num);
                num *= 10;
            }

            // массивы для заданий 5 и 6.

            int[] array = { 1, 2, 3, 4, 5 };
            int[] array2 = { 7, 8, 9, 10, 11, 12, 13 };
            Array.Copy(array, 0, array2, 0, 3);
            Console.WriteLine(string.Join(",", array2));

            Array.Resize(ref array, array.Length * 2);
            Console.WriteLine(string.Join(",", array));
        }
    }
}