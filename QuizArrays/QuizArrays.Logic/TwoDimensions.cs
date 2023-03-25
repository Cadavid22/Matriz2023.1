namespace QuizArrays.Logic
{
   public class TwoDimensions
    {
        private int[] _array;

        public TwoDimensions(int n, int m)
        {
            N = n;
            M = m;
            _array = new int[n, m];
        }

        public int M { get; }

        public int N { get; }

        public void Fill()
        {
            Fill(1, 100);
        }

        public void Fill(int minimun, int maximun)
        {
            Random random = new Random();

            for (int i = 0; i < N; i++)
            {
                int j = 0;
                for (; j < M; j++)
                {
                    _array[i, j] = random.Next(minimun, maximun);
                }
            }
        }

        public string ToOneDimension()
        {
            int _top = N * M;
            OneDimension oneDimension = new OneDimension(_top);

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    oneDimension.Add(_array[i, j]);
                }
            }

            string output = oneDimension.ToString();

            return output;
        }

        public override string ToString()
        {
            string output = string.Empty;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    output += $"{_array[i, j]}\t";
                }
                output += "\n";
            }
            return output;
        }
    }
}

