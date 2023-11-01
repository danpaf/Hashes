namespace Hashes.Utils;

public class FindDuplicate
{
    public static bool HasDuplicatesBruteForce(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                if (arr[i] == arr[j])
                {
                    return true;
                }
            }
        }

        return false;
    }

    public static bool HasDuplicatesHashSet(int[] arr)
    {
        HashSet<int> set = new HashSet<int>();
        foreach (int num in arr)
        {
            if (set.Contains(num))
            {
                return true;
            }

            set.Add(num);
        }

        return false;
    }

    public static bool HasDuplicatesSorting(int[] arr)
    {
        Array.Sort(arr);
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] == arr[i - 1])
            {
                return true;
            }
        }

        return false;
    }

    public static bool HasDuplicatesQuadratic(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                for (int k = j + 1; k < n; k++)
                {
                    if (arr[i] == arr[j])
                    {
                        return true;
                    }
                }
            }
        }

        return false;
    }

    public static bool HasDuplicateCounting(int[] arr, int maxElement)
    {
        int[] countArray = new int[maxElement + 1];
        foreach (int num in arr)
        {
            if (countArray[num] > 0)
            {
                return true;
            }

            countArray[num]++;
        }
        return false;
    }

}