// перевод в двоичную систему
//11=>1011 26=>11010 9=>1001
//
string BinaryNumber(int number)
{
    string bin="";
    while (number / 2 != 0)
    {
        bin = Convert.ToString(number % 2)+bin;
        number /= 2;
    }
    if(number>=1)
    {
        bin = Convert.ToString(number % 2)+bin;
    }
    return bin;
}
Console.WriteLine("введите число");
int numberDec = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(BinaryNumber(numberDec));