string[] array = {"Coding", "is", "the", "best", "!!"}; // Создаем строковый массив

void ResultArray(string[] array) // Метод принимает на вход созданный нам массив
{
    string[] arr = new string[array.Length]; // Создаем новый массив
    
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) // Проверяем является ли строка меньше, или равно трем символам
        {
            arr[i] = array[i]; // Записываем элемент со старого массива в новый массив
        }
    }
    
    for (int j = 0; j < arr.Length; j++)
    {
        System.Console.Write(arr[j] + " "); // Выводим элементы нового массива
    }
}

ResultArray(array); // Вызываем метод