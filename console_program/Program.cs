// Выборка элементов из данного массива в новый массив по условию
// Будут приведены несколько способов решения


string[] stringArray = new string[] 
    {
    ":-)", "hello", "2", "world", "-2", 
    "Russia", "Kazan", "123456", "computer science",
    "mother", "GeekBrains", "GB", "car" 
    };

// 1st method

string[] SortArrayByLength(string[] stringArray, int sortingElementLength)
{
    string tempString = String.Empty;
    for (int i = 0; i < stringArray.Length; i++)
    {
        if (stringArray[i].Length <= sortingElementLength) 
            tempString = string.Concat(tempString, stringArray[i], " ");
    }

    string[] sortedArray = tempString.Split(" ");
    return sortedArray;
}



string[] s = SortArrayByLength(stringArray, 3);

foreach (string i in s)
{
    System.Console.WriteLine(i);
}


// 2st method with Linq operators

// var selectElements = stringArray.Where(i => i.Length <= sortingElementLength);

// foreach(string i in selectElements)
//     System.Console.WriteLine(i);

