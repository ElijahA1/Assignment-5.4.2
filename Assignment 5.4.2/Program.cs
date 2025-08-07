namespace Assignment_5._4._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix1 = { { 1, 2 },
                               { 2, 3 } }; //2+2 =4

            int[,] matrix2 = { { 1, 2, 3 },
                               { 3, 4, 5 },
                               { 4, 5, 6 } }; // 3+ 4 + 4 = 11;

            int[,] matrix3 = { { 1, 2, 3, 4 },
                               { 4, 5, 6, 7 },
                               { 7, 8, 9, 8 },
                               { 6, 7, 8, 9 } }; // 6+4+8+6 = 24

            Console.WriteLine(matrixRightDiagonalSum(matrix1));
            Console.WriteLine(matrixRightDiagonalSum(matrix2));
            Console.WriteLine(matrixRightDiagonalSum(matrix3));
        }

        static int matrixRightDiagonalSum(int[,] matrix)
        {
            // First number is always 0, and length-1
            // To get the next number increment matrix array and decrement the array element
            // repeat until matrix length

            int sum = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                sum += matrix[i, matrix.GetLength(0) - 1 - i];
            }

            return sum;
        }
    }
}
