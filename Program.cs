/*
2.Write a program, which reads two arrays from the console and checks
whether they are equal (two arrays are equal when they are of equal
length and all of their elements, which have the same index, are equal).
3.Write a program, which compares two arrays of type char
lexicographically (character by character) and checks, which one is first
in the lexicographical order.
4.Write a program, which finds the maximal sequence of consecutive
equal elements in an array. E.g.: {1, 1, 2, 3, 2, 2, 2, 1}  {2, 2, 2}.
5.Write a program, which finds the maximal sequence of consecutively
placed increasing integers. Example: {3, 2, 3, 4, 2, 2, 4}  {2, 3, 4}.
6.Write a program, which finds the maximal sequence of increasing
elements in an array arr[n]. It is not necessary the elements to be
consecutively placed. E.g.: {9, 6, 2, 7, 4, 7, 6, 5, 8, 4}  {2, 4, 6, 8}.
7.Write a program, which reads from the console two integer numbers N
and K (K<N) and array of N integers. Find those K consecutive
elements in the array, which have maximal sum.
8.Sorting an array means to arrange its elements in an increasing (or
decreasing) order. Write a program, which sorts an array using the
algorithm "selection sort".
9.Write a program, which finds a subsequence of numbers with
maximal sum. E.g.: {2, 3, -6, -1, 2, -1, 6, 4, -8, 8}  11
10. Write a program, which finds the most frequently occurring element in
an array. Example: {4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3}  4 (5 times).
11. Write a program to find a sequence of neighbor numbers in an array,
which has a sum of certain number S. Example: {4, 3, 1, 4, 2, 5, 8},
S=11  {4, 2, 5}.
*/







class Program
{
    public static int[] items = new int[] { 6, 20, 12, 34, 56, 78, 89, 97, 41, 90, 57 };

    public static void Main()
    {
        try
        {
            /*
        1.Write a program, which creates an array of 20 elements of type
        integer and initializes each of the elements with a value equals to the
        index of the element multiplied by 5. Print the elements to the console.

        */

            //Question1();
            //Question2();
            // Question3();
            // Question4();
            //Question5();
            // Question6();
            //Question10();
            // MergeSort();
            //Question7();
            // Question8(items);
            Console.Write(Question16());
            // Question17();
            // Question18();
            // Question19();
        }
        catch (System.Exception ex)
        {

            Console.WriteLine("An Error Occured " + ex.Message);
        }

    }

    private static void Question19()
    {
            //Using sieve of eratosthenes
           Console.Write("Enter a number from the range 1,n: ");
           var n=int.Parse(Console.ReadLine()!);
           
    }

    private static void Question18()
    {
        throw new NotImplementedException();
    }

    private static void Question17()
    {
        throw new NotImplementedException();
    }

    public static string Question16()
    {
        // Implementation of binary search
        
        int[] sortedArray = Question8(items);
        int findNumber = 6;
        int low, mid, high;
        low = 0;
        high = sortedArray.Length-1;
        while (low <= high)
        {
            mid = low + (high - low) / 2;
            Console.WriteLine(mid);

            if (sortedArray[mid] == findNumber)
            {
                return $"Found at index {mid}";
            }
            else if (sortedArray[mid] > findNumber)
            {
                high = mid-1;

            }
            else if (sortedArray[mid] < findNumber)
            {
                low = mid + 1;
            }
        }
        return "Not Present in this array";

    }

    private static int[] Question8(int[] dataset)
    {
        //Implemenation of merge sort 
        int n = dataset.Length;
        for (int i = 0; i < n - 1; i++)
        {
            int min = i;
            for (int j = i + 1; j < n; j++)
            {
                if (dataset[j] < dataset[min])
                {
                    min = j;
                }
                (dataset[i], dataset[min]) = (dataset[min], dataset[i]);
            }
        }
        return dataset;
    }

    private static void Question10()
    {
        Console.Write("Enter the  array elements like this 3,2,3,4,2,2,2: ");
        string first = Console.ReadLine()!;
        var array = first.Split(",");
        int highest = 0;
        Dictionary<string, int> dictionary = new(array.Length);
        for (var i = 0; i < array.Length; i++)
        {
            if (dictionary.ContainsKey(array[i]))
            {
                dictionary[array[i]]++;
            }
            else
            {
                dictionary.Add(array[i], 1);

            }

        }

        foreach (var item in dictionary)
        {
            if (item.Value > highest)
            {
                highest = item.Value;
            }
            Console.WriteLine(item);
        }
        string mostOccuring = "";
        foreach (var item in dictionary)
        {
            if (dictionary[item.Key] == highest)
            {
                mostOccuring = item.Key;
            }
        }
        Console.WriteLine("The most occuring element is: " + mostOccuring);
        Console.WriteLine(" It occured: " + highest);

    }




    private static void Question6()
    {
        throw new NotImplementedException();
    }

    private static void Question5()
    {
        Console.Write("Enter the  array elements like this 3,2,3,4,2,2,2: ");
        string first = Console.ReadLine()!;
        var array = first.Split(",");

        List<int> sequence = new();
        for (int i = 0; i < array.Length - 1; i++)
        {
            if (ConvertStringToInt(array[i]) < ConvertStringToInt(array[i + 1]))
            {
                sequence.Add(i);
                sequence.Add(i + 1);
            }
        }

        Console.Write("{");
        for (int i = sequence.First(); i <= sequence.Last(); i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.Write("}");
    }

    private static void Question7()
    {
        Console.Write("Enter the total number of elements (N): ");
        int N = int.Parse(Console.ReadLine()!);

        Console.Write("Enter the number of consecutive elements to find (K): ");
        int K = int.Parse(Console.ReadLine()!);

        int[] array = new int[N];

        Console.WriteLine("Enter the elements of the array:");

        for (int i = 0; i < N; i++)
        {
            array[i] = int.Parse(Console.ReadLine()!);
        }

        int maxSum = int.MinValue;
        int startIndex = 0;

        for (int i = 0; i <= N - K; i++)
        {
            int sum = 0;

            for (int j = i; j < i + K; j++)
            {
                sum += array[j];
            }

            if (sum > maxSum)
            {
                maxSum = sum;
                startIndex = i;
            }
        }

        Console.WriteLine("The consecutive elements with the maximal sum are:");

        for (int i = startIndex; i < startIndex + K; i++)
        {
            Console.Write(array[i] + " ");
        }
    }

    // private static int[] MergeSort(int[] dataset)
    // {
    //     //Merge Sort
    //     int length = dataset.Length;
    //     if (length > 1)
    //     {
    //         decimal round = length/2;
    //         decimal mid = Math.Round(round);
    //         int[] leftarr = dataset[0, mid];
    //     }
    // }

    private static void Question4()
    {
        Console.Write("Enter the  array elements like this 1,2,2,2,5,6: ");
        string first = Console.ReadLine()!;

        var array = first.Split(",");
        // foreach (var item in array)
        // {
        //     Console.WriteLine(item);
        // }
        List<int> sequence = new();
        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] == array[i + 1])
            {
                sequence.Add(i);
                sequence.Add(i + 1);
            }
            else
            {
                sequence.Clear();
            }
        }

        // foreach (var item in sequence)
        // {
        //     Console.WriteLine(item);

        // }
        // Console.Write(sequence.First());
        // Console.Write(sequence.Last());

        Console.Write("{");
        for (int i = sequence.Last(); i >= sequence.First(); i--)
        {
            Console.Write(array[i] + " ");
        }
        Console.Write("}");

    }

    private static void Question3()
    {
        Console.Write("Enter the first array elements like this Acder: ");
        string first = Console.ReadLine()!;
        var firstArray = first.ToCharArray();
        Console.Write("Enter the second array elements like this Abcde: ");
        string second = Console.ReadLine()!;
        var secondArray = second.ToCharArray();
        var maxLenght = (firstArray.Length + secondArray.Length) / 2;
        var sortedArray = new char[maxLenght];
        for (int i = 0; i < maxLenght; i++)
        {
            if (firstArray[i].CompareTo(secondArray[i]) == 0)
            {
                sortedArray[i] = firstArray[i];
            }
            else if (firstArray[i].CompareTo(secondArray[i]) == -1)
            {
                sortedArray[i] = firstArray[i];
            }
            else if (firstArray[i].CompareTo(secondArray[i]) == 1)
            {
                sortedArray[i] = secondArray[i];
            }
            else
            {
                sortedArray[i] = firstArray[i];
            }
        }
        foreach (var item in sortedArray)
        {
            Console.Write(item + " ");
        }
    }

    private static void Question2()
    {
        Console.Write("Enter the first array elements like this 123456: ");
        string first = Console.ReadLine()!;
        var firstArray = first.ToCharArray();
        Console.Write("Enter the second array elements like this 123456: ");
        string second = Console.ReadLine()!;
        var secondArray = second.ToCharArray();
        int count = 0;
        if (firstArray.Length == secondArray.Length)
        {
            for (int i = 0; i < firstArray.Length; i++)
            {
                if (firstArray[i] == secondArray[i])
                {
                    count += 1;
                }
                else
                {
                    Console.WriteLine("the array are not equal");
                    break;
                }
            }
        }
        else
        {
            Console.WriteLine("The arrays are not equal becuase of their length");
        }
    }

    private static void Question1()
    {
        var array = new int[20];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = i;
        }
        foreach (var item in array)
        {
            Console.WriteLine(item * 5);
        }
    }
    public static int ConvertStringToInt(string number)
    {
        return int.Parse(number);
    }
}