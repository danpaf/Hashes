namespace Hashes.Hashes
{
    class ClosedAddressingHashTable
    {
        private int size;
        private List<int>[] hashtable;

        public ClosedAddressingHashTable(int size)
        {
            this.size = size;
            hashtable = new List<int>[size];
            for (int i = 0; i < size; i++)
            {
                hashtable[i] = new List<int>();
            }
        }

        public void Insert(int key)
        {
            int index = HashFunction(key);
            hashtable[index].Add(key);
            Console.WriteLine("LOG: " + index);
        }

        private int HashFunction(int key)
        {
            return (11 * key + 4) % size;
        }

        public List<int>[] GetTable()
        {
            return hashtable;
        }
    }
}