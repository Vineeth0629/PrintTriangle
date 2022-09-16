namespace PrintTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the desired width: ");
            int TrianleWidth = Convert.ToInt32(Console.ReadLine());

            int height = TrianleWidth;
            for (int row = 0; row < height; row++)
            {
                for (int column = 0; column < TrianleWidth; column++)
                {
                    Console.Write(num);
                }

                Console.WriteLine();
                TrianleWidth--;
            }
        }
    }
}