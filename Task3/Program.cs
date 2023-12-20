{
        int[] array = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
        int count = 0;
        
        foreach (var element in array) {
            if (element >= 20 && element <= 90) {
                count++;
            }
        }
        
        Console.WriteLine("Количество элементов массива, значения которых лежат в отрезке от 20 до 90]. " + count);
    }
