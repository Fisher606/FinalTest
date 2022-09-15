
Random rnd = new Random();

string[] CreateArray()              //Метод создания массива чисел от 1 до 99999, в количестве от 3 до 4 чисел
{
    int size = rnd.Next(3, 4);
    string[] array = new string[size];
    
    for (int i = 0; i < size; i++)
        array[i] = Convert.ToString(rnd.Next(0, 100000));
    
    return array;
}




int GettingNewSize(string[] array)          //Метод описанный блок-схемой
{
    int newSize = 0;

    for (int i = 0; i < array.Length; i++)
        if (array[i].Length <= 3) newSize++;
    
    return newSize;
}

string[] BildNewArray(string[] existArray)
{
    int newSize = GettingNewSize(existArray);
    string[] newArray = new string[newSize];
    int index = 0;

    for (int i = 0; i < existArray.Length; i++)
        if (existArray[i].Length <= 3)
        {
            newArray[index] = existArray[i];
            index++;
        }

    return newArray;
}

void ShowArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1)
            Console.Write(", ");
    }

    if (array.Length > 0)
        Console.WriteLine();
}

string[] array = CreateArray();
Console.WriteLine("В сгенерированном массиве:");
ShowArray(array);

Console.WriteLine("Элементы с длиной 3 символа и меньше:");
string[] newArray = BildNewArray(array);
ShowArray(newArray);
if (newArray.Length == 0)
    Console.WriteLine("(нет)");