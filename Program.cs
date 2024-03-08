// Задаем массивы для решения задачи

string[] mass = { "Hello", "2", "world", ":-)" };
string[] mass1 = { "1234", "1567", "-2", "computer science" };
string[] mass2 = { "Russia", "Denmark", "Kazan" };

// Распечатывание массива, то что внутри скобок
void PrintMass(string[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write("“" + $"{array[i]}" + "”," + " ");
    }
    Console.Write("“" + $"{array[array.Length - 1]}" + "”");
}

//Распечатывание массивов в скобках
void Print(string[] array)
{
    Console.Write("[");
    PrintMass(array);
    Console.Write("] → [");
    if (Dlina(array) > 0)
    {
        PrintMass(NewMass(array));
    }
    Console.Write("]");
}



// Формирование нового массива

// Длина нового массива

int Dlina(string[] array)
{
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length < 4)
        {
            j++;
        }
    }
    return j;
}

// Формирование массива

string[] NewMass(string[] array)
{
    string[] NewArray = new string[Dlina(array)];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length < 4)
        {
            NewArray[j] = array[i];
            j++;
        }
    }
    return NewArray;
}




System.Console.WriteLine();
Print(mass);
System.Console.WriteLine();

Print(mass1);
System.Console.WriteLine();

Print(mass2);
