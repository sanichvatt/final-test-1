//Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из 
//строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с 
//клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется 
//пользоваться коллекциями, лучше обойтись исключительно массивами.
//Примеры:
//[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
//[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
//[“Russia”, “Denmark”, “Kazan”] → []
Console.Clear();
string[] arraytext = {"Hello", "2", "world", ":-)"};

void PrintArray(string[] matr)
{
    for (int i = 0; i < matr.Length; i++)
    {
        System.Console.Write($"{matr[i]}, ");        
    }
    System.Console.WriteLine();
}

int CounterArray(string[] matr)
{
    int count = 0;
    for (int i = 0; i < matr.Length; i++)
    {
        string arg = matr[i];
        int leng = arg.Length;
        if (leng < 4) count = count + 1;
    }
    return count;
}

void FillArray(string[] array1, string[] array2)
{
    int j = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        
        string arg = array1[i];
        int leng = arg.Length;
        if (leng < 4)
        {
            array2[j] = array1[i];
            j++;
        }          
    }
}