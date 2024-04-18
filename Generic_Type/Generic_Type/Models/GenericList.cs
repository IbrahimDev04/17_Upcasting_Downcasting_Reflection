namespace Generic_Type.Models
{
    internal class GenericList<T>
    {
        public int[] arr;
        public int Capasity { get; set; } = 5;
        public int Count { get; set; }
        public GenericList()
        {
            arr = new int[Capasity];
        }

        public void Add(int value)
        {
            if (Count == arr.Length)
            {
                Array.Resize(ref arr, Count + Capasity);
            }
            arr[Count] = value;
            Count++;
        }

        public void GetElement()
        {
            for (int i = 0; i < Count; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
