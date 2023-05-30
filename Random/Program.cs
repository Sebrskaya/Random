using System;
using System.Xml.Serialization;

class RandomSeed
{
    static void Main()
    {
        int n = 1000000;
        int[] numbers = new int[n];
        Random random = new Random(69); // Установка сида в значение 69
        // заполнение массива
        for (int i = 0; i < numbers.Length; i++)
        {
            int randomNumber = random.Next(1, 11); // Генерация случайного числа от 1 до 10
            numbers[i] = randomNumber;
        }


        Period(numbers);//Вычисление периода повторения рандома
        Frequancy(numbers);//Вычисление вероятностей чисел от 1 до 10
        CustomFrequancy(numbers);// Подгонка и вычисление выероятностей числел от 1 до 5
       
    }

    private static void Frequancy(int[] array)
    {
        int[] count = Count(array);//Подсчёт всех значений
        Console.WriteLine("Freaquancy");
        for (int i = 0; i < 10; i++)//Вывод
        {
            Console.WriteLine("Кол-во элементов со значением "+(i+1)+" : "+count[i]+ " Вероятность появления : " + (double) count[i] / array.Length);
        }
            
    }

    private static void CustomFrequancy(int[] array)
    {
        
        Console.WriteLine("CustomFreaquancy");
        for (int i = 0; i < array.Length; i++)
        {
            switch (array[i])
            {
                case 6:
                    array[i] = 2;
                    break;
                case 7:
                    array[i] = 3;
                    break;
                case 8:
                    array[i] = 3;
                    break;
                case 9:
                    array[i] = 4;
                    break;
                case 10:
                    array[i] = 5;
                    break;

            }
        }
        int[] count = Count(array);
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Кол-во элементов со значением " + (i + 1) + " : " + count[i] + " Вероятность появления : " + (double)count[i] / array.Length);
        }


    }
    private static  int [] Count(int[]array)
    {
        int[] count = new int[11];
        for (int i = 0; i < array.Length; i++)
        {
            switch (array[i])
            {
                case 1:
                    count[0]++;
                    break;
                case 2:
                    count[1]++;
                    break;
                case 3:
                    count[2]++;
                    break;
                case 4:
                    count[3]++;
                    break;
                case 5:
                    count[4]++;
                    break;
                case 6:
                    count[5]++;
                    break;
                case 7:
                    count[6]++;
                    break;
                case 8:
                    count[7]++;
                    break;
                case 9:
                    count[8]++;
                    break;
                case 10:
                    count[9]++;
                    break;
            
            }
        }
        return count;
    }
    private static void Period(int[] array)
    {
        double count = 0;// счётчик повторений (частота появлений)

        for (int i = 0; i < array.Length - 7; i++)
        {
            if (array[i] == array[0] & array[i + 1] == array[1] & array[i + 2] == array[2] & array[i + 3] == array[3] & array[i + 4] == array[4] & array[i + 5] == array[5] & array[i + 6] == array[6] & array[i + 7] == array[7])
            {
                count++;
            }
        }
        Console.WriteLine("Кол-во повторений Random: " + count);
    }
    private static void Print(int[] array)
    {
        // Вывод сгенерированных чисел
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i]);
        }
    }
}
