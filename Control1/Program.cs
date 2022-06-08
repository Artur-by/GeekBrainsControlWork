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



Console.Write("Введите длину массива: ");
int N = Convert.ToInt32(Console.ReadLine());

string[] array = CreateArray(N);
for (int i = 0; i < N; i++)
{
    Console.Write($"Введите {i + 1}-й элемент массива: ");
    array[i] = Convert.ToString(Console.ReadLine());
}

int countNewEl = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3) countNewEl++;
}

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

PrintArray(array);
System.Console.WriteLine();
PrintArray(newArray);
