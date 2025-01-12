// split

// Split an array into two parts

(T[], T[]) SplitArray<T>(T[] array, int index)
{
    if (array == null)
        throw new ArgumentNullException(nameof(array), "Array can't be null.");

    if (index < 0 || index > array.Length)
        throw new ArgumentOutOfRangeException(nameof(index), "Index is out of the bounds of the array.");

    int firstPartLength = index + 1;

    T[] firstPart = new T[firstPartLength];
    T[] secondPart = new T[array.Length - firstPartLength];

    Array.Copy(array, firstPart, firstPartLength);
    Array.Copy(array, firstPartLength, secondPart, 0, secondPart.Length);

    return (firstPart, secondPart);
}


//longest

// Find longest strings

List<string> FindLongestString(string[] strings)
{
    if (strings == null)
        throw new ArgumentNullException(nameof(strings), "Array cannot be null.");

    List<string> longestStrings = new List<string>();
    longestStrings.Add(strings[0]);

    if (strings.Length == 1)
    {
        return longestStrings;
    }

    int maxLength = strings[0].Length;

    for (int i = 1; i < strings.Length; i++)
    {
        if (strings[i].Length > maxLength)
        {
            longestStrings.Clear();
            maxLength = strings[i].Length; ;
            longestStrings.Add(strings[i]);
        }
        else if (strings[i].Length == maxLength)
        {
            longestStrings.Add(strings[i]);
        }
    }

    return longestStrings;
}

//invert

// Reverse an array, without using .Reverse()

T[] ReverseArray<T>(T[] array)
{
    if (array == null)
        throw new ArgumentNullException(nameof(array), "Array can't be null.");

    T[] reversedArray = new T[array.Length];

    for (int i = 0; i < array.Length; i++)
    {
        int mirrorIndex = array.Length - 1 - i;
        reversedArray[i] = array[mirrorIndex];
    }
    return reversedArray;
}

//validate

// Validate person name

static bool IsValidName(string name)
{

}