﻿Console.Write("Введите значения через запятую, / или пробел:");
string? mas = Console.ReadLine();
string [] newArray  =  mas.Split(',','/',' ');

Console.Write("Введите максимальное количество символов в искомых значениях:");
int elementsCondition = Convert.ToInt32 (Console.ReadLine());

string [] selectArray = new string [CountingSelectElements(newArray,elementsCondition)];

WriteSelectElements (newArray,selectArray,elementsCondition);

Console.Write ($"Следующие элементы значений имеют {elementsCondition} и меньше символов: ");
WriteArray (selectArray);

int CountingSelectElements (string [] array, int condition)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= condition)
        {
            count++;
        }
    }
    return count; 

}

void WriteSelectElements (string [] array, string [] resultArray, int condition)
{
    int count = 0;
     for(int i = 0; i < resultArray.Length; i++)
    {
        for (int j = count; j < array.Length; j++)
        {
            if (array[j].Length <= condition)
            {
                resultArray[i] = array[j];
                count = j+1;
                break;
            }
            
            
        }
    }
}

void WriteArray (string [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write (array[i] + " ");
    }

    Console.WriteLine();
}
