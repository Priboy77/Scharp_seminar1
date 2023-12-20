int[] numbers = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
int evenCount = 0;

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] % 2 == 0)
    {
        evenCount++;
    }
}

Console.WriteLine("Колличество четных чисел в массиве " + evenCount + "");
