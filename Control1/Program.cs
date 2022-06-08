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
    for (int i = 0; i < array.Length; i++)
        Console.Write($" {array[i]} ");
}


// метод определения длины элемента

int LenElement(string el)
{
    int lenEl = el.Length;
    return lenEl;
}


Console.Write("Введите длину массива: ");
int N = Convert.ToInt32(Console.ReadLine());

string[] array = CreateArray(N);
for (int i = 0; i < N; i++)
{
    Console.Write($"Введите {i + 1}-й элемент массива: ");
    array[i] = Convert.ToString(Console.ReadLine());
}

PrintArray(array);
