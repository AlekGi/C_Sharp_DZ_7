// Задача 3: Задайте произвольный массив. 
// Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

int[] Printarray(int[] array){
for (int i = 0; i < array.Length; i++){
    System.Console.Write(array[i]+" ");
}
return array;
}

void ArrayMirror(int[] array, int firstindex = 0)
{
    if (firstindex != array.Length)
    {
        ArrayMirror(array, firstindex + 1);
        Console.Write($"{array[firstindex]} ");
    }
}

//---------------------

int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
System.Console.WriteLine($"Изначальный массив: ");
Printarray(array);
System.Console.WriteLine();
System.Console.WriteLine("Развернули массив с помощью рекурсии: ");
ArrayMirror(array);