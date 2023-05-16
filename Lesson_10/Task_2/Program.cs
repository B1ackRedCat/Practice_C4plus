namespace Task_2
{
    class FixedLengthStringArray : IComparable<FixedLengthStringArray>
    {
        private string[] array;

        public int LowerBound { get; private set; }
        public int UpperBound { get; private set; }

        public int Length => UpperBound - LowerBound + 1;

        public FixedLengthStringArray(int lowerBound, int upperBound)
        {
            if (lowerBound > upperBound)
            {
                throw new ArgumentException("Lower bound cannot be greater than upper bound");
            }

            LowerBound = lowerBound;
            UpperBound = upperBound;
            array = new string[Length];
        }

        public string this[int index]
        {
            get
            {
                if (index < LowerBound || index > UpperBound)
                {
                    throw new IndexOutOfRangeException("Index is out of range");
                }
                return array[index - LowerBound];
            }
            set
            {
                if (index < LowerBound || index > UpperBound)
                {
                    throw new IndexOutOfRangeException("Index is out of range");
                }
                array[index - LowerBound] = value;
            }
        }

        public FixedLengthStringArray Concatenate(FixedLengthStringArray otherArray)
        {
            if (Length != otherArray.Length)
            {
                throw new ArgumentException("Arrays must have the same length");
            }

            FixedLengthStringArray resultArray = new FixedLengthStringArray(LowerBound, UpperBound);

            for (int i = LowerBound; i <= UpperBound; i++)
            {
                resultArray[i] = array[i - LowerBound] + otherArray[i];
            }

            return resultArray;
        }

        public void PrintElement(int index)
        {
            Console.WriteLine($"Element at index {index}: {this[index]}");
        }

        public void PrintArray()
        {
            Console.WriteLine("Array elements:");

            for (int i = LowerBound; i <= UpperBound; i++)
            {
                Console.WriteLine($"Index {i}: {this[i]}");
            }
        }

        public int CompareTo(FixedLengthStringArray other)
        {
            // Implement comparison logic based on a specific field of the array
            // For example, compare based on the first element
            return this[LowerBound].CompareTo(other[LowerBound]);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            FixedLengthStringArray array1 = new FixedLengthStringArray(0, 2);
            array1[0] = "Hello";
            array1[1] = "World";
            array1[2] = "!";

            FixedLengthStringArray array2 = new FixedLengthStringArray(0, 2);
            array2[0] = "This";
            array2[1] = "is";
            array2[2] = "C#";

            FixedLengthStringArray concatenatedArray = array1.Concatenate(array2);

            concatenatedArray.PrintArray();
            concatenatedArray.PrintElement(1);
        }
    }
}