// Задаем массив вещественных чисел
        double[] numbers = { 2.5, 1.3, 4.7, 3.1, 2.9 };
        double min = numbers[0];
        double max = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] < min)
                min = numbers[i];
            
            if (numbers[i] > max)
                max = numbers[i];
        }
        double difference = max - min;
        Console.WriteLine("Разница между максимальным и минимальным элементами массива: " + difference);
    