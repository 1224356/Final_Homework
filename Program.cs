int getMasLength()
{
    Console.Write("Из скольки элементов хотите задать массив? ");
    string value = Console.ReadLine();
    string errMassage = "Необходимо ввести целое число, которое больше 0!";
    if ((int.TryParse(value, out int arrLen) == true) && (arrLen > 0))
    {
        return arrLen;
    }
    else
    {
        Console.WriteLine($"Вы ввели: \"{value}\". " + errMassage);
        return getMasLength();
    }    
}

string[] getMas(int numOfElems)
{
    string[] arrG = new string[numOfElems];
    for (int iArrG = 0; iArrG < numOfElems; iArrG++)
    {
        if (iArrG == numOfElems - 1) Console.Write($"Введите последний {iArrG + 1} элемент массива: ");
        else Console.Write($"Введите {iArrG + 1} элемент массива: ");
        arrG[iArrG] = Console.ReadLine();
    }
    return arrG;
}

void printResult(string[] arrP)
{
    if (arrP.Length == 0) 
    {
        Console.WriteLine("В массиве нет элементов, длина которых меньше, либо равна 3 символам!");
    }
    else
    {
        Console.Write("[");
        for (int iArrP = 0; iArrP < arrP.Length; iArrP++)
        {
            Console.Write($"\"{arrP[iArrP]}\"");
            if (iArrP == arrP.Length - 1) 
                Console.Write("]");
            else
                Console.Write(", ");
    }
    }
}

string[] mas = getMas(getMasLength());
string[] foundMas = Array.FindAll(mas, mas => mas.Length <= 3);
printResult(foundMas);
