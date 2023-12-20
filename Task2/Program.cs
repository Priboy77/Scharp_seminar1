Console.Write("Введите натуральное число: ");
        int number = int.Parse(Console.ReadLine());
        int digitsCount = (int)Math.Floor(Math.Log10(number)) + 1;      
        int[] digits = new int[digitsCount];       
        int index = digitsCount - 1;
        while (number > 0)
        {
            digits[index] = number % 10;
            number /= 10;
            index--;
        }       
        Console.WriteLine("Массив цифр числа:");
        for (int i = 0; i < digitsCount; i++)
        {
            Console.WriteLine(digits[i]);
        }