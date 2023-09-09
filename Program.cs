/// <summary>
/// Метод для получения массива строк, введенных пользователем
/// </summary>
/// <returns>Возвращает массив из введенной пользователем строку, разбитой по пробелу</returns>
string[] TypeAndSplitText()
{
Console.WriteLine("Введите строки через пробел: ");
string inputText = Console.ReadLine();
return inputText.Split(' ');
}

/// <summary>
/// Метод для получения условия отбора по длине и проверки на положительность
/// </summary>
/// <returns>Возвращает введенное пользователем условие отбора по длине</returns>
int TypeLimit()
{
Console.WriteLine("Введите условие отбора по длине (должно быть > 0): ");
int limit = Convert.ToInt32(Console.ReadLine());
if (limit<0) limit = TypeLimit();
return limit;
}

/// <summary>
/// Метод для создания массива строк, удовлетворяющих условию отбора по длине в входном массиве
/// </summary>
/// <param name="inputArray">Входной массив</param>
/// <param name="limit">Условие отбора по длине</param>
/// <returns></returns>
string[] GetLimitedStrings(string[] inputArray, int limit)
{
    int arrayLen = inputArray.Length;
    string preResultArray = String.Empty;
    for (int i = 0; i < arrayLen; i++)
    {
        if (inputArray[i].Length <= limit) preResultArray = preResultArray + ' ' + inputArray[i];
    }
    string[] resultArray = preResultArray.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    return resultArray;
}


string[] inputArray = TypeAndSplitText();
int limit = TypeLimit();
string[] limitedStrings = GetLimitedStrings(inputArray, limit);

Console.WriteLine($"В введенном вами массиве строк присутствуют следующие строки с количеством символов не более {limit} [{String.Join(",", limitedStrings)}]");
