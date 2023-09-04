int[] filterEvens(int[] array)
{
    int[] result = { };
    int[] tmpArray = new int[10];
    int tal = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 != 0)
        {
            continue;
        }
        tmpArray[tal++] = array[i];
        if (tal >= tmpArray.Length)
        {
            int oldSize = result.Length;
            Array.Resize(ref result, oldSize + tal);
            Array.ConstrainedCopy(tmpArray, 0, result, oldSize, tal);
            tal = 0;
        }
    }

    if (tal > 0)
    {
        int oldSize = result.Length;
        Array.Resize(ref result, oldSize + tal);
        Array.ConstrainedCopy(tmpArray, 0, result, oldSize, tal);
    }

    return result;
}