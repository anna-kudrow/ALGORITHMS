

//                      АРИФМЕТИЧЕСКАЯ ПРОГРЕССИЯ


// Напишите программу которая принимает на вход число N и возвращает сумму чисел от 1 до N.
// Решение при помощи арифметической прогрессии, сложность - O(1) константный алгоритм:

// Console.Clear();
// Console.WriteLine("Input a number: ");
// int n = int.Parse(Console.ReadLine()!);
// Console.WriteLine(((1 + n) / 2.0) * n); 

// Решение при помощи цикла, линейный алгоритм О(n):

// Console.Clear();
// System.Console.WriteLine("Input a number: ");
// int n = int.Parse(Console.ReadLine()!), result = 0;
// for (int i = 0; i <= n; i++)
// {
//     result += i;
// }
// System.Console.WriteLine($"Summ of numbers from 1 to {n} = {result}");
                


                    // СОРТИРОВКА ПУЗЫРЬКОМ, квадратичный алгоритм О(n ** 2)



// Console.Clear();
// System.Console.WriteLine("Input size of array: ");
// int n = int.Parse(Console.ReadLine()!);
// int [] array = new int[n];
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(-20,21);
// }
// System.Console.WriteLine($"Initial array: [{string.Join(", ", array)}]");

// for (int i = 0; i < array.Length; i++)
// {
//     for (int j = 0; j < array.Length - 1; j++)
//     {
//         if(array[j] < array[j + 1])(array[j], array[j + 1]) = (array[j + 1], array[j]);
//     }       
// }
// System.Console.WriteLine($"End array:  [{string.Join(", ", array)}]");





// Последовательность Фибоначчи Рекурсией:
// int fib(int n)
// {
//     if (n == 0 || n == 1)
//     return 1;
//     return fib (n - 1) + fib (n - 2);
// }

// Console.Clear();
// System.Console.Write("Input a number: ");
// int n = int.Parse(Console.ReadLine()!);
// System.Console.WriteLine(fib(n));

// Последовательность Фибоначчи циклом:

// System.Console.Write("Input a number: ");
// int n = int.Parse(Console.ReadLine()!), a0 = 0, a1 = 1, x;
// for (int i = 0; i < n; i++)
// {
//     x = a0 + a1;
//     a0 = a1;
//     a1 = x;
// }

// System.Console.WriteLine(a0);



                            // СОРТИРОВКА ВЫБОРОМ


// int [] SortSelection (int [] collection)      
// {
//     int size = collection.Length;
//     for (int i = 0; i < size - 1; i++)
//     {
//         int pos = i;
//         for (int j = i + 1; j < size; j ++)
//         {
//             if (collection[j] < collection[pos])
//             pos = j;

//         }
//         int temp = collection[i];
//         collection[i] = collection[pos];
//         collection[pos] = temp;
//     }
//     return collection;
// }
// var arr = new int [] {9, 6, 0, 5, 7, 3, 1, 2};
// System.Console.WriteLine(String.Join(' ', arr));    
// SortSelection(arr);
// System.Console.WriteLine(String.Join(' ', arr));   



//                     СОРТИРОВКА ПОДСЧЁТОМ

                    //    ДЛЯ ЦИФР (0-9):

// int[] array = {0,2,3,2,1,5,9,1,1};

// int []sortedArray = CountingSort(array);

// // CountingSort(array);

// System.Console.WriteLine(string.Join(", ", sortedArray));

// void CountingSort(int[] inputArray)
// {
//     int[] counters = new int[10];         // создаём второй массив для записи повторений цифр
//     for (int i = 0; i < inputArray.Length; i++)
//     {
//          counters[inputArray[i]]++;       // считаем количество повторений цифр(превращаем элемент первого массива в индекс второго массива как бы и делаем в этом индексе +1)
//     }

//     int index = 0;
//     for (int i = 0; i < counters.Length; i++)  //обход второго  массива повторений 
//     {
//         for (int j = 0; j < counters[i]; j++) // вложенный цикл для
//         {
//             inputArray[index] = i; // 
//             index++;
//         }
//     }
// }


        //   СОРТИРОВКА ПОДСЧЁТОМ ДЛЯ ЧИСЕЛ (РАСШИРЕННЫЙ МЕТОД):

// int[] array = {0,20,3,2,1,5,29,10,1};

// int []sortedArray = CountingSortExtended(array);


// int [] CountingSortExtended (int[] inputArray)
// {
//     int max = inputArray.Max();

//     int[] counters = new int [max + 1];

//     for (int i = 0; i < inputArray.Length; i++)
//     {
//         counters[inputArray[i]]++;
//     }

//     int index = 0;

//     for (int i = 0; i < counters.Length; i++)
//     {
//         for (int j = 0; j < counters[i]; j++)
//         {
//             inputArray[index] = i;
//             index++;
//         }
//     }

//     return inputArray;
// }


//            СОРТИРОВКА ПОДСЧЁТОМ ДЛЯ МАССИВОВ С ОТРИЦАТЕЛЬНЫМИ ЧИСЛАМИ


int[] array = {-10,-5,-9,0,2,5,1,3,1,0,1};
int[] sortedArray = CountingSortExtended(array);
System.Console.WriteLine(string.Join(", ", sortedArray));

int [] CountingSortExtended (int [] array)

{
    int max = array.Max();
    int min = array.Min();

    int offset = -min;
    int[] sortedArray = new int[array.Length];
    int[] counters = new int[max + offset + 1];

    for (int i = 0; i < array.Length; i++)
    {
        counters[array[i] + offset]++;
    }

    int index = 0;
    for (int i = 0; i < counters.Length; i++)
    {
        for (int j = 0; j < counters[i]; j++)
        {
            sortedArray[index] = i;
            index++;
        }
    }
    return sortedArray;
}








