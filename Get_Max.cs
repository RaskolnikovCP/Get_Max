public int GetMax(int[] arr)
        {
            int max = 0;

            int size = arr.Length;

            for (int i = 0; i < size; i++)
            {
                if (arr[i] >= max)
                {
                    max = arr[i];
                }
            }

            return max;
        }
