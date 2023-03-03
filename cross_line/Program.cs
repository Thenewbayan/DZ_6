// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("введите параметры для 1 прямой по формуле y=k*x+b, где к и b вы задаете сами через enter");
double CoefX1=Convert.ToInt32(Console.ReadLine());//coof K
double CoefB1=Convert.ToInt32(Console.ReadLine());// coof B
Console.WriteLine("введите параметры для 2 прямой по формуле y=k*x+b, где к и b вы задаете сами через enter");
double CoefX2=Convert.ToInt32(Console.ReadLine()); //coof K2
double CoefB2=Convert.ToInt32(Console.ReadLine());// coof B2
//решаем через равенство (в пересечении у и х для обоих уравнений равны, значит по у их можно приравнять)
//K*x+b=K2*x+b2=> K*x-K2*x=b2-b=>x=(b2-b)/(K-K2)
double coordX=0;
double coordY=0;
if ((CoefX1==CoefX2)&&(CoefB1==CoefB2))
{
    Console.WriteLine("Наши прямые совпадают и имеют бесконечное число общих точек");
}
if ((CoefX1-CoefX2)!=0)
{
coordX=(CoefB2-CoefB1)/(CoefX1-CoefX2);
coordY=(CoefX1*coordX)+CoefB1;
}
else 
{
    Console.WriteLine("прямые не преесекаются");
}
Console.WriteLine($"наши прямые пересекаются в точке  {Math.Round(coordX, 2)};{Math.Round(coordY, 2)}");
// Console.WriteLine(coordX);
// Console.WriteLine(coordY);