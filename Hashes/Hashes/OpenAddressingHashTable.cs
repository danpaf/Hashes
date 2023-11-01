namespace Hashes.Hashes;

class OpenAddressingHashTable
{
    public readonly int Size;
    private readonly int[] _hashtable;

    public OpenAddressingHashTable(int size)
    {
        this.Size = size;
        _hashtable = new int[size];
        for (int i = 0; i < size; i++)
        {
            _hashtable[i] = -1;
        }
    }

    public OpenAddressingHashTable(int[] hashtable)
    {
        _hashtable = hashtable;
    }

    public void Insert(int key)
    {
        int index = HashFunction(key);
        while (_hashtable[index] != -1)
        {
            index = (index + 1) % Size;
        }
        _hashtable[index] = key;
        Console.WriteLine("LOG: " + index);
    }

    private int HashFunction(int key)
    {
        return (11 * key + 4) % Size;
    }

    public int[] GetTable()
    {
        return _hashtable;
    }
}