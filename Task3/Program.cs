// Задача №3: Задайте произвольный массив. Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.

void PrintElemetsArray(int index, int[] arr)
{
    if(index == arr.Length) return;
    PrintElemetsArray(index+1, arr);
    Console.Write($"{arr[index]} ");
}


int[] array = {1, 2, 5, 0, 10 ,34};
PrintElemetsArray(0, array);
