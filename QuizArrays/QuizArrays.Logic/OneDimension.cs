namespace QuizArrays.Logic
{
    public class OneDimension
    {
        private int _top; 
        private int[] _array;

        public OneDimension(int n)
        {
             N = n;
            _array = new int[n];
            _top = 0;
        }
        public bool IsEmpty => _top == 0;

        public bool IsFull => _top == N;

        public int N { get; }

        public void Add(int number)
        {
            if (IsFull)
            {
                throw new Exception("The array is full.");
            }

            _array[_top] = number;
            _top++;
        }

        public override string ToString()
        {
            if (IsEmpty)
            {
                return "Empty array.";
            }

            string output = string.Empty;
            for (int i = 0; i < _top; i++)
            {
                output += $"{_array[i]}\t";
            }
            return output;
        }
    }
}

