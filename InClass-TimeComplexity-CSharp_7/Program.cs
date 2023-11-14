using System;

int[] data = { 6, 2, 4, 1, 3, 5 };
for (int j = 0; j < data.Length; j++)
{
    int key = data[j];
    int i = j - 1;

    while ((i >= 0) && (data[i] > key))
    {
        data[i + 1] = data[i];
        i = i - 1;
    }

    data[i + 1] = key;

    for (int sorted = 0; sorted < data.Length; sorted++)
    {
        Console.Write(data[sorted] + " ");
    }
    Console.Write("\n");
}