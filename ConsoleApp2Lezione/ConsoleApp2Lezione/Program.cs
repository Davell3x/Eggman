int IndexOfMin(int[] array, int from, int to)
{
    int indexOfMin = from;

    for (int i = from + 1; i <= to; ++i)
    {
        if (array[i] < array[indexOfMin])
        {
            indexOfMin = i;
        }
    }
    return indexOfMin;
}

void Swap(int[] array, int i, int j)

{
    int temp = array[i];
    array[i] = array[j];
    array[j] = temp;
}

void SortArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        int temp = IndexOfMin(array, i, array.Length - 1);
        Swap(array, i, temp);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"array[{i}]={array[i]}");
    }
}

int[] nums = [0, 2, 4, 6, 8, 12, 0, -1];

int indexOfNum = IndexOfMin(nums, 0, nums.Length - 1);
Console.WriteLine(indexOfNum + $"  {nums[indexOfNum]}");

PrintArray(nums);
SortArray(nums);
PrintArray(nums);


int FacIter(int n)
{
    int product = 1;
        for (int i = 1; i <= n; i++);
    {
        product *= i;
    }
    return product;
}

int FibRec(int n) =>;
{

}

int FibIter(int n)
{
int product = 1;
    for (int i = 1; i <= n; i++) ;
    {
        product *= i;
    }
    return product;
}