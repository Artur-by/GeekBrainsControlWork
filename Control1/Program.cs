// Написать программу, которая из имеющегося массива строк формирует новый массив строк, 
// элементы которого меньше либо равны 3 символам


// метод создания массива
string[] CreateArray(int N)
{
    string[] array = new string[N];
    return array;
}

//метод вывода элементов массива в консоль
void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
        Console.Write($"'{array[i]}', ");
    Console.Write($"'{array[array.Length - 1]}'");
    Console.WriteLine("]");
}

// Вводим количество элементов первоначального массива N

Console.Write("Введите длину массива: ");
string N = Console.ReadLine();

int number;
// проверяем на правильность данных
while (true)
{
    if (int.TryParse(N, out number) == false)
    {
        Console.WriteLine("Вы ввели не числовое значение, попробуйте еще раз!");
        Console.Write("Введите длину массива: ");
        N = Console.ReadLine();
    }
    else if (number <= 0)
    {
        Console.WriteLine("Длина массива не может быть отрицательной или нулевой!");
        Console.Write("Введите длину массива: ");
        N = Console.ReadLine();
    }
    else break;
}

// Формируем пустой массив с количеством N символов и вводим данные
string[] array = CreateArray(number);
for (int i = 0; i < number; i++)
{
    Console.Write($"Введите {i + 1}-й элемент массива: ");
    array[i] = Console.ReadLine();
}

// считаем количество элементов с числом символов <= 3
int countNewEl = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3) countNewEl++;
}

if (countNewEl == 0)
{
    Console.WriteLine("В заданном массиве:");
    PrintArray(array);
    Console.WriteLine("нет элементов, удовлетворяющих условию!");
    Console.WriteLine("Итоговоый массив:  []");
}
else
{
    //Формируем новый итоговый массив 
    string[] newArray = CreateArray(countNewEl);
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newArray[j] = array[i];
            j++;
        }
    }

    // Выводим результат в консоль
    Console.WriteLine("Исходный массив:");
    PrintArray(array);
    Console.WriteLine();
    Console.WriteLine("Итоговый массив:");
    PrintArray(newArray);
}