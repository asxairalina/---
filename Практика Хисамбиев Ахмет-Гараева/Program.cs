int a;
int d;

while (true)
{
    Console.WriteLine("Введите сумму");
    a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите скидку");
    d = Convert.ToInt32(Console.ReadLine());

    if (a >= 1 && a <= 100000 && d >= 1 && d <= 100)
    {
        double c = a - (a * d) / 100;
        Console.WriteLine(c);
        break;

    }

    else
    {
        Console.WriteLine("Неправильные данные");   
    }
}

