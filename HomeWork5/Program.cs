void Zadacha34()
// Задача 34: Задайте массив заполненный случайными положительными
// трёхзначными числами. Напишите программу, которая покажет количество
// чётных чисел в массиве.
{
    Random rand = new Random();
    int size = rand.Next(1,15);
    int[] array = new int[size];
        
    FillArray(array,100,999);
    Console.WriteLine("Исходный массив:");
    PrintArray(array);
    CountCh(array);
}

void Zadacha36()
// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
{
    Random rand = new Random();
    int size = rand.Next(1,15);
    int[] array = new int[size];
        
    FillArray(array,-100,100);
    Console.WriteLine("Исходный массив:");
    PrintArray(array);
    SumNech(array);
}

void Zadacha38()
// Задача 38: Задайте массив вещественных чисел. Найдитеразницу между
// максимальным и минимальным элементов массива.
{
    Random rand = new Random();
    int size = rand.Next(2,16);
    double[] array = new double[size];
        
    FillArrayReal(array);
    Console.WriteLine("Исходный массив:");
    PrintArrayReal(array);
    Console.WriteLine("Разница между максимальным и минимальным элементами массива равна " +
        Math.Round(MaxArrayReal(array) - MinArrayReal(array),4));
}

void ZadachaDop1()
// Задача 1. Задан массив из случайных цифр на 15 элементов. На вход
// подаётся трёхзначное натуральное число. Напишите программу, которая 
// определяет, есть в массиве последовательность из трёх элементов,
// совпадающая с введённым числом.
{
    Random rand = new Random();
    int size = 15;
    int[] array = new int[size];
        
    FillArray(array,0,8);
    Console.WriteLine("Исходный массив:");
    PrintArray(array);
    
    Console.WriteLine("Введите трехзначное натуральное число");
    int number = Convert.ToInt32(Console.ReadLine());
    if (number >= 100 && number <= 999)
        Posledovatelnost(array,number);
    else
        Console.WriteLine("Введено не трехзначное натуральное число");
}

void ZadachaDop2()
// Задача 2. На вход подаются два числа случайной длины.
// Найдите произведение каждого разряда первого числа на каждый разряд
// второго. Ответ запишите в массив.
{
    Console.WriteLine("Введите первое число");
    int number1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе число");
    int number2 = Convert.ToInt32(Console.ReadLine());

    int size = CountDigits(number1) * CountDigits(number2);
    int[] array = new int[size];
            
    FillArrayDop(array,number1,number2);
    Console.WriteLine("Искомый массив:");
    PrintArray(array);
}

void ZadachaDop3()
// Задача 3. Найдите все числа от 1 до 1000000, сумма цифр которых
// в три раза меньше их произведений. Подсчитайте их количество.
{
    int size = 0;
    int[] array = new int[size];
    int number = 1000000;
            
    array = FillArraySumPr(array,number);

    size = array.Length;
    if (size > 0)
    {
        Console.WriteLine($"Числа от 1 до {number}, сумма цифр которых в три раза меньше их произведений:");
        PrintArray(array);
        Console.WriteLine("Количество таких чисел равно " + array.Length);
    }
    else
        Console.WriteLine($"Чисел от 1 до {number}, сумма цифр которых в три раза меньше их произведений, нет");   
}

void ZadachaDop4()
// Задача 1*. Дан массив массивов, состоящих из натуральных чисел,
// размер которого 5. Для каждого элемента-массива требуется найти
// сумму его элементов и вывести массив с наибольшей суммой.
// Если таких массивов несколько, вывести массив с наименьшим индексом.
{
    int sizeArAr = 5;
    int[][] ArrayArray = new int[sizeArAr][];
    Random rand = new Random();
        
    for (int i = 0; i < sizeArAr; i++)
    {
        ArrayArray[i] = new int[rand.Next(1,11)];
    };
                
    Console.WriteLine("Исходный массив массивов:");
    FillArrayArray(ArrayArray);
    PrintArrayArray(ArrayArray);

    int MaxSum = SumArray(ArrayArray[0]);
    int MaxIndex = 0;

    for (int i = 1; i <sizeArAr; i++)
    {
        if (SumArray(ArrayArray[i]) > MaxSum)
        {
            MaxSum = SumArray(ArrayArray[i]);
            MaxIndex = i;
        }
    }

    Console.WriteLine($"Массив с наибольшей суммой, равной {MaxSum} и наименьшим индексом, равным {MaxIndex}:");
    PrintArray(ArrayArray[MaxIndex]);
}

void FillArray(int[] array, int startNumber = -10, int finishNumber = 10)
// Заполнение массива случайными целыми числами
{
    Random rand = new Random();

    finishNumber++;

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(startNumber,finishNumber);
    };
}

void PrintArray(int[] array)
// Печать массива из целых чисел
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + ", ");
    };
    Console.WriteLine("\b\b]");
}

void CountCh(int[] array)
// Подсчет количества четных чисел в массиве
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            count++;
    }

    Console.WriteLine("Количество четных чисел в массиве равно " + count);
}

void SumNech(int[] array)
// Подсчет суммы элементов массива, стоящих на нечётных позициях
{
    int sum = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (i  %2 != 0)
            sum += array[i];
    }

    Console.WriteLine("Сумма элементов массива, стоящих на нечётных позициях равна " + sum);
}

void FillArrayReal(double[] array)
// Заполнение массива случайными вещественными числами
{
    Random rand = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(50 - rand.NextDouble() * 100, 4);
    };
}

void PrintArrayReal(double[] array)
// Печать массива из вещественных чисел
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + "  ");
    }
    Console.WriteLine("\b\b]");
}

double MinArrayReal(double[] array)
//Поиск минимального элемента массива из вещественных чисел
{
    double MinElem = array[0];
    
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < MinElem)
            MinElem = array[i];
    }

    return MinElem;
}

double MaxArrayReal(double[] array)
//Поиск максимального элемента массива из вещественных чисел
{
    double MaxElem = array[0];
    
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > MaxElem)
            MaxElem = array[i];
    }

    return MaxElem;
}

void Posledovatelnost(int[] array, int numb)
//Метод, который определяет, есть ли в массиве последовательность из трёх
// элементов, совпадающая с переданным в параметре числом
{
    bool flag = false;

    for (int i = 0; i < array.Length - 2; i++)
    {
        if ((array[i] * 100 + array[i+1] * 10 + array[i+2] == numb) && !flag)
            flag = true;
    }
        
    if (flag)
        Console.WriteLine("Массив содержит последовательность из трёх элементов, совпадающих с числом " + numb);  
    else
        Console.WriteLine("Массив не содержит последовательность из трёх элементов, совпадающих с числом " + numb);  
}

int CountDigits(int numb)
// Метод принимает на вход число и возвращает количество цифр в числе.
{
    int count = 0;
    
    if (numb == 0)
        count = 1;
    else
        while (Math.Abs(numb) > 0)
        {
            numb = numb / 10;
            count++;
        }   

    return count;
}

void FillArrayDop(int[] array, int numb1, int numb2)
// Заполнение массива из целых чисел, состоящего из произведения
// каждого разряда первого числа-параметра на каждый разряд 
// второго числа-параметра
{
    int index = array.Length - 1;
    int tempNumb = numb2;

    if (numb1 == 0 || numb2 == 0)
    {
        for (int i = 0; i <= index; i++)
            array[i] = 0;
    }
    else
    {    while (Math.Abs(numb1) > 0)
        {
            while (Math.Abs(numb2) > 0)
            {
                array[index] = (numb1 % 10) * (numb2 % 10);
                numb2 /= 10;
                index--;
            }
            numb2 = tempNumb;
            numb1 /= 10;
        }
    }
}

int SumDigits(int numb)
// Метод принимает на вход число и возвращает сумму цифр в числе.
{
    int Sum = 0;
    
    while (Math.Abs(numb) > 0)
    {
        Sum = Sum + (numb % 10);
        numb = numb / 10;
    }

    return Sum;
}

int PrDigits(int numb)
// Метод принимает на вход число и возвращает произведение цифр в числе.
{
    int Pr = 1;
    
    if (numb == 0)
        Pr = 0;
    else
        while (Math.Abs(numb) > 0)
        {
            Pr = Pr * (numb % 10);
            numb = numb / 10;
        }

    return Pr;
}

int[] FillArraySumPr(int[] array, int numb)
// Заполнение массива числами от 1 до numb, сумма цифр которых
// в три раза меньше их произведений 
{
    int index = 0;

    for (int i = 1; i <= numb; i++)
    {
        if (PrDigits(i) == 3 * SumDigits(i))
        {
            Array.Resize(ref array,index+1);
            array[index] = i;
            index++;
        }
    }
    
    return array;
}

void FillArrayArray(int[][] ArArray, int startNumber = 1, int finishNumber = 100)
// Заполнение массива массивов случайными натуральными числами
{
    Random rand = new Random();
    
    finishNumber++;

    for (int i = 0; i < ArArray.Length; i++)
    {
        for (int j = 0; j < ArArray[i].Length; j++)
            ArArray[i][j] = rand.Next(startNumber,finishNumber);
    }
}

void PrintArrayArray(int[][] ArArray)
// Печать массива массивов из целых чисел
{
    for (int i = 0; i < ArArray.Length; i++)
    {
        Console.Write($"Element({i}): [");
        for (int j = 0; j < ArArray[i].Length; j++)
            Console.Write(ArArray[i][j] + ", ");
        Console.WriteLine("\b\b]");
    }
}

int SumArray(int[] arr)
// Поиск суммы элементов массива из целых чисел
{
    int sum = 0;
    
    for (int i = 0; i < arr.Length; i++)
    {
        sum += arr[i];
    }

    return sum;
}


Zadacha34();
Zadacha36();
Zadacha38();
ZadachaDop1();
ZadachaDop2();
ZadachaDop3();
ZadachaDop4();