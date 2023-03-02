//  Пользователь вводит с клавиатуры M чисел. 
//  Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

Console.WriteLine("введите несколько целых чисел через клавишу enter");
Console.WriteLine("вводите числа сколько угодно раз, если вы хотите остановиться введите слово -КОНЕЦ-");
int size = array.Length;
int[] GetArray(int size)
{
for (int i = 0; i < size; i++)
{
    string Input = Console.ReadLine();
    if ((Input != "КОНЕЦ") && (int.TryParse(Input, out array[i]))) ;
    {
        array[i] = Convert.ToInt32(Input);
    };
    else 
    {
        Console.WriteLine("вы ввели неверное значение, попробуйте снова");
    }
}
}
int GetArray(20);
for (int i = 0; i < array.Length; i++)
int count=0;
{
    if (array[i] > 0)
    {
        count = count+1;
    }
} 
Console.WriteLine($"вы ввели {count} положительных чисел");