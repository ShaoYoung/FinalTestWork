//Итоговая проверочная работа

//Формирование массива из строк. Запрашивает ввод строки. Разделители - пробелы. На выходе массив из строк.
string[] GetStringArray()
{
    Console.WriteLine("Введите произвольный строковый массив, используя ПРОБЕЛ в качестве разделителя элементов: ");
    string inputString = Console.ReadLine();
    string[] stringArray = inputString.Split(' ');
    //если введённая строка пустая, уменьшаем размер массива до нуля (для последующего вывода по шаблону)
    if (inputString.Length == 0)
        Array.Resize(ref stringArray, 0);
    return stringArray;
}

//Печать массива строк
void PrintArray(string[] array)
{
    //если массив не пустой, то выводим на печать согласно шаблону
    if (array.Length > 0)
        Console.WriteLine($"[\"{string.Join("\", \"", array)}\"]");
    //иначе пустые скобки
    else
        Console.WriteLine("[]");
}

//Формирование массива из строк, длина которых меньше или равна 3 символам. На входе строковый массив. На выходе строковый массив.
string[] GetStringArrayThreeSymbol(string[] inputStringArray)
{
    string[] outputStringArray = new string[0];
    int lengthOutArray = 0;
    foreach (string element in inputStringArray)
    {
        //если длина строки (элемента массива) <=3
        if (element.Length <= 3)
        {
            //увеличиваем размерность выходного массива на 1
            lengthOutArray++;
            Array.Resize(ref outputStringArray, lengthOutArray);
            //записываем в новую ячейку выходного массива найденный элемент
            outputStringArray[lengthOutArray - 1] = element;
        }
    }
    return outputStringArray;
}

Console.Clear();

string[] stringArray = GetStringArray();
Console.WriteLine("Вы ввели массив:");
PrintArray(stringArray);

Console.WriteLine("Массив из строк, длина которых меньше или равна трём символам: ");
PrintArray(GetStringArrayThreeSymbol(stringArray));