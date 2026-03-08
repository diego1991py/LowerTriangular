namespace Task.Backend
{
    public class Matrix
    {
        private int _order;
        private int[,] _matrixD;

        public Matrix(int order)
        {
            Order = order;
            _matrixD = new int[Order, Order];
        }

        public int Order
        {
            get => _order;
            set => _order = ValidateOrder(value);
        }


        public void FillMatrix()
        {
            for (int i = 0; i < Order; i++)
            {
                for (int j = 0; j < Order; j++)
                {
                    _matrixD[i, j] = i + j;
                }
            }
        }

        public void ShowMatrix()
        {
            for (int i = 0; i < Order; i++)
            {
                for (int j = 0; j < Order; j++)
                {
                    Console.Write($"{_matrixD[i, j],4} ");
                }

                Console.WriteLine();
            }
        }

        public void ShowLowerTriangle()
        {
            for (int i = 0; i < Order; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write($"{_matrixD[i, j],4} ");
                }

                Console.WriteLine();
            }
        }

        private int ValidateOrder(int order)
        {
            if (order <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(order),
                    "The order of the matrix cannot be less than 1");
            }

            return order;
        }
    }
}