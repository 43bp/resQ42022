/*
Написать программу, которая из имеющегося массива строк
формирует массив из строк, длина которых меньше либо равна 3 символа...
*/

Console.WriteLine($"Введите кол-во элементов, которые Вы хотите записать: ");
int size = Convert.ToInt32(Console.ReadLine());
string[] arrayString = new string[size];
WriteStringArray (arrayString, size);
Console.WriteLine();
Console.WriteLine("Введенные Вами значения:");
PrintArray(arrayString);
Console.WriteLine();
int qntSym = 3;  // устанавливаем фильтр по кол-ву символов (вдруг когда-нибудь нужно будет 4-х символьные элементы отбирать)
string[] selectElemArrByQuantSym = SelectElemArrByQuantSym(arrayString, qntSym);
Console.WriteLine($"Из них, кол-во символов в которых <= {qntSym}:");
PrintArray(selectElemArrByQuantSym);

// метод наполнения пользоваетелем массива string
void WriteStringArray (string[] arr, int length)
{
    int num = 1;
    for (int i = 0; i < length; i++)
    {
        Console.WriteLine($"Введите элемент №{num}: ");
        arr[i] = Console.ReadLine();
        num++;
    }
}

// метод выборки элементов из массива string с фильтром по кол-ву символов элемента
string[] SelectElemArrByQuantSym (string[] stringarr, int qnt)
{
   int count = 0; // считаем кол-во элементов с кол-вом символов <= qnt
   for (int k = 0; k < stringarr.Length; k++)
    {
        if (stringarr[k].Length <= qnt)
            {
                count = count + 1;
            }
    }
   string[] selectElemArr = new string[count]; // создаем и наполняем новый массив элементами с кол-вом символов <= qnt
   int i = 0;
   int j = 0;
   while (i < stringarr.Length)
   {
        if (stringarr[i].Length <= qnt) 
            {
                selectElemArr[j] = stringarr[i];
                i++;
                j++;
            }
        else i++;
   }
   return selectElemArr;
}

// метод печати массива string
void PrintArray (string[] array)
{
    Console.Write("[");
        for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write(array[i]);
    }
    Console.WriteLine("]");
}