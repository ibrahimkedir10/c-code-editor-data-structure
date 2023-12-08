public class ArrayClass
{
    private int[] data;
    private int DEFAULT_SIZE = 10;
    private int size = 0;

    public ArrayClass()
    {
        this.data = new int[DEFAULT_SIZE];
    }

    public void AddArray(int num)
    {
        if (isFull())
        {
            resize();
        }

        data[size] = num;
        size++;
    }

    private void resize()
    {
        int[] temp = new int[data.Length * 2];
        Array.Copy(data, temp, data.Length);
        data = temp;
    }

    private bool isFull()
    {
        return size == data.Length;
    }

    // Indexer property to access elements by index
    public int this[int index]
    {
        get
        {
            if (index < 0 || index >= size)
            {
                throw new IndexOutOfRangeException("Index out of range.");
            }
            return data[index];
        }
    }

    // Property to get the current size of the array
    public int Size
    {
        get { return size; }
    }
}
