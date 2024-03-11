
// Task Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
string[] inputArray = new string[] { "Hello", "2", "world", ":-)" }; 
        
        int count = 0;
        for (int i = 0; i < inputArray.Length; i++)
        {
            if (inputArray[i].Length <= 3)
            {
                count++;
            }
        }

        string[] resultArray = new string[count];
        int index = 0;
        for (int i = 0; i < inputArray.Length; i++)
        {
            if (inputArray[i].Length <= 3)
            {
                resultArray[index] = inputArray[i];
                index++;
            }
        }

        
        Console.WriteLine("Результат:");
        for (int i = 0; i < resultArray.Length; i++)
        {
            Console.Write(resultArray[i] + " ");
        }
