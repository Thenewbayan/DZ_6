//  Пользователь вводит с клавиатуры M чисел. 
//  Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

Console.WriteLine("введите несколько целых чисел через клавишу enter");
Console.WriteLine("укажите сколько чисел вы хотите ввести");
int size=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("вводите числа сколько угодно раз, если вы хотите остановиться введите слово -КОНЕЦ-");
int[] GetArray(int size)
{
    int [] array=new int [size];
    int arraySize=array.Length;
for (int i = 0; i < size; i++)
{
    string Input = Console.ReadLine();
    if ((Input != "КОНЕЦ") && (int.TryParse(Input, out array[i]))) 
    {
        array[i] = Convert.ToInt32(Input);
    }
    else 
    {
        Console.WriteLine("вы ввели неверное значение, попробуйте снова");
    }
}
return array;
}
int[] resultArray=GetArray(size);
Console.WriteLine(String.Join(";", resultArray));
int count=0;
{
    for (int i=0; i<resultArray.Length; i++)
    {
        if (resultArray[i]>0)
        {
        count = count+1;
        }
    }
} 
Console.WriteLine($"вы ввели {count} положительных чисел");