// Итоговая контрольная работа по основному блоку:  
// Написать программу, которая из имеющегося массива строк 
// формирует новый массив из строк, длина которых меньше, либо равна 3 символам.

Console.Clear();

string[] initialArray ={"123", "Poul", "John", "{+}", "George", "Rin", "Linda", "Emi", "Yo"};

Console.WriteLine("====initial array============");
PrintArray(initialArray);
Console.WriteLine();

int ReducedArrayLength(string[] array)
{
int j = 0;
for (int i = 0; i < initialArray.Length; i++)
{
    if (initialArray[i].Length <= 3)
    {
        initialArray[j] = initialArray[i];
        j++;
    }
}
return j;
}

int reducedArrayLength = ReducedArrayLength(initialArray);

string[] reducedArray = new string[reducedArrayLength];

for (int k = 0; k < reducedArrayLength; k++)
{
    reducedArray[k] = initialArray[k];
}

// // метод вывода на консоль элементов массива
void PrintArray(string[] arr)
{
for (int i = 0; i < arr.Length; i++)
   {
    Console.Write($"{arr[i]}  ");
   }
}
Console.WriteLine();
Console.WriteLine("======reduced array==========");
PrintArray(reducedArray);
Console.WriteLine();

