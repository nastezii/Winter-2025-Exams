// split

// split an array into two parts

(T[], T[]) SplitArray<T>(T[] array, int index)
{
    if (array == null)
        throw new ArgumentNullException(nameof(array), "Array can't be null.");

    if (index < 0 || index > array.Length)
        throw new ArgumentOutOfRangeException(nameof(index), "Index is out of the bounds of the array.");
}

