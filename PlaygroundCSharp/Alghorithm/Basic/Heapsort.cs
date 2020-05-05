namespace Alghorithm.Basic
{
    // Inplace: yes
    // Stable: no

    // Complexity
    // best: n log(n)
    // average: n log(n)
    // worst: n log(n)

    // Q: What is inplace sorting algorithm that guarantee n log(n)?
    // A: Heapsort

    // Q: What are the reasons that heapsort is not used often in practice?
    // A: Inner loop in longer then in mergesort,
    //    references to memory are all over the place,
    //    it's not stable

    static class Heapsort
    {
        public static void Sort(int[] array)
        {
            int size = array.Length;
            for (int ptr = size / 2; ptr >= 1; ptr--)
            {
                Sink(array, ptr, size);
            }

            while (size > 1)
            {
                Exchange(array, 1, size);
                Sink(array, 1, --size);
            }
        }

        private static void Sink(int[] array, int ptr, int size)
        {
            while (2 * ptr <= size )
            {
                int j = 2 * ptr;
                if (j < size && array[j - 1] < array[j])
                {
                    ++j;
                }

                if (array[j - 1] < array[ptr - 1])
                {
                    break;
                }

                Exchange(array, ptr, j);
                ptr = j;
            }
        }

        private static void Exchange(int[] array, int i, int j)
        {
            --i;
            --j;

            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
}
