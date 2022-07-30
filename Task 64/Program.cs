void NumbersRec(int a)
{
    if (a == 0) return;
    Console.Write($"{a} ");
    NumbersRec(a - 1);
}
Console.Write("Введите число начала убывающей прогрессии: ");
int number = Convert.ToInt32(Console.ReadLine());
NumbersRec(number); 