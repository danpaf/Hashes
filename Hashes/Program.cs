using Hashes.Hashes;
using Hashes.Utils;



int[] C = new int[9];
for (int i = 0; i < 9; i++)
{
    C[i] = i;
}

OpenAddressingHashTable openHashTable = new OpenAddressingHashTable(100);
foreach (int key in C)
{
    openHashTable.Insert(key);
}

int[] resultOpenAddressing = openHashTable.GetTable();
Console.WriteLine("Open Addressing:");
foreach (int value in resultOpenAddressing)
{
    Console.Write(value + " ");
}

int[] B = {67, 13, 49, 24, 40, 33, 58};
ClosedAddressingHashTable closedHashTable = new ClosedAddressingHashTable(9);
foreach (int key in B)
{
    closedHashTable.Insert(key);
}

List<int>[] resultClosedAddressing = closedHashTable.GetTable();
Console.WriteLine("\nClosed Addressing:");
foreach (var bucket in resultClosedAddressing)
{
    foreach (int value in bucket)
    {
        Console.Write(value + " ");
    }
}

int[] A = { 4, 2, 7, 1, 10, 9, 5, 2 };

Console.WriteLine("\nbrute-force:");
bool resultBruteForce = FindDuplicate.HasDuplicatesBruteForce(A);
Console.WriteLine(resultBruteForce);

Console.WriteLine("Алгоритм, работающий за O(n log n):");
bool resultSorting = FindDuplicate.HasDuplicatesSorting(A);
Console.WriteLine(resultSorting);

Console.WriteLine("Алгоритм с ожидаемым (средним) временем работы O(n):");
bool resultLinearExpected = FindDuplicate.HasDuplicatesHashSet(A);
Console.WriteLine(resultLinearExpected);

Console.WriteLine("Алгоритм с ожидаемым (средним) временем работы O(N^2):");
bool resultK = FindDuplicate.HasDuplicateCounting(A,10);
Console.WriteLine(resultK);