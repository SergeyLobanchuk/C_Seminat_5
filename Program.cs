// Задача 1. Задайте массив в пределах от -9 до +9 и сложить все отрицательные
// и положительные числа

// int [] CreatRandomArray (int size,
//                         int min,
//                         int max) //заполнение массива
// {
//     int [] newArray = new int [size]; // инициализация массива
//     for (int i = 0; i < size; i++)
//     {
//     newArray[i] = new Random().Next(min, max + 1); //Заполняем массив, +1 т.к. последнее число не входит в диапозон
//     }
//     return newArray; //вернуть массив    
// }

// void ShowArray (int [] arr)
// {
    
//     Console.Write("Массив -> ");
//     for (int i = 0; i < arr.Length; i++)
//     {
//         Console.Write(arr[i]+" ");
//     }
//     Console.WriteLine();
// }

// void FindMinMaxSum (int[] myArray)
// {
//     int sumPossitive = 0;
//     int sumNegative = 0;
//     for (int i = 0; i < myArray.Length; i++)
//     {
//         if (myArray[i] > 0) sumPossitive += myArray[i];
//         else sumNegative += myArray[i];
//     }
//     Console.WriteLine($"Сумма положительных чисел в массиве равно -> {sumPossitive}");
//     Console.WriteLine($"Сумма отрицательных чисел в массиве равно -> {sumNegative}");
// }

// Console.WriteLine("Input size ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input min ");
// int min= Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input max ");
// int max = Convert.ToInt32(Console.ReadLine());
// int[] myArray = CreatRandomArray(size, min, max);
// ShowArray(myArray);
// FindMinMaxSum(myArray);


//Задача 2. Напишите программу замена элементов массива:
// положительные элементы замените на соответствующие отрицательные, и наоборот.

//[-4, -8, 8, 2] -> [4, 8, -8, -2]

// int [] CreatRandomArray (int size,
//                         int min,
//                         int max) //заполнение массива
// {
//     int [] newArray = new int [size]; // инициализация массива
//     for (int i = 0; i < size; i++)
//     {
//     newArray[i] = new Random().Next(min, max + 1); //Заполняем массив, +1 т.к. последнее число не входит в диапозон
//     }
//     return newArray; //вернуть массив    
// }

// void ShowArray (int [] arr) // Вывести наш массим из метода CreatRandomArray
// {
    
//     Console.Write("Массив -> ");
//     for (int i = 0; i < arr.Length; i++)
//     {
//         Console.Write(arr[i]+" ");
//     }
//     Console.WriteLine();
// }


// int[] invertArray(int[] myArray) // Инвертировать массив
// {
//     for (int i = 0; i < myArray.Length; i++)
//     {
//         myArray[i] *= (-1);
//     }
//     return myArray;
// }


// Console.WriteLine("Input size ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input min ");
// int min= Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input max ");
// int max = Convert.ToInt32(Console.ReadLine());
// int[] myArray = CreatRandomArray(size, min, max);
// ShowArray(myArray);
// ShowArray(invertArray(myArray));


//Задача 3.Задайте массив. Напишите программу, которая определяет,
// присутствует ли заданное число в массиве. Запрос чисел массива у пользователя

//4; массив [6, 7, 19, 345, 3] -> нет

// int [] CreatPlayerArray (int size) //заполнение массива
// {
//     int [] newArray = new int [size]; // инициализация массива
//     for (int i = 0; i < size; i++)
//     {
//         //Заполняем массив от пользователя
//         Console.WriteLine($"Inpit {i+1} number ");
//         newArray[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     return newArray; //вернуть массив    
// }


// void ShowArray (int [] arr) // Вывести наш массим из метода CreatRandomArray
// {
    
//     Console.Write("Массив -> ");
//     for (int i = 0; i < arr.Length; i++)
//     {
//         Console.Write(arr[i]+ " ");
//     }
//     Console.WriteLine();
// }


// bool findNumber(int number, int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (number == arr[i]) return true;
//     }
//     return false; 
// }

// Console.WriteLine("Input size ");
// int size = Convert.ToInt32(Console.ReadLine());
// int [] MyArray = CreatPlayerArray(size);
// ShowArray(MyArray);
// Console.WriteLine("Input your number ");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine (findNumber(number, MyArray));

//Задача 4. Задайте одномерный массив из 123 случайных чисел. 
// Найдите количество элементов массива, 
//значения которых лежат в отрезке [10,99].

int [] CreatRandomArray (int size) //заполнение массива
{
    int [] newArray = new int [size]; // инициализация массива
    for (int i = 0; i < size; i++)
    {
    newArray[i] = new Random().Next(1, 1001); //Заполняем массив, +1 т.к. последнее число не входит в диапозон [1,1000)
    }
    return newArray; //вернуть массив    
}

void ShowArray (int [] arr) // Вывести наш массим из метода CreatRandomArray
{
    
    Console.Write("Массив -> ");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i]+ " ");
    }
    Console.WriteLine();
}

void Find(int []array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= 10 && array[i]<=99) count += 1;
    }
    Console.WriteLine($"Кол-во чисел {count}");
}


Console.WriteLine("Input size ");
int size = Convert.ToInt32(Console.ReadLine());
int [] MyArray = CreatRandomArray(size);
ShowArray(MyArray);
Find(MyArray);
