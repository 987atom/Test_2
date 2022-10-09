namespace Test_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введи что вы хотите сделать где" +
                "1) Игра Угадай число " +
                "2) Таблица умножения" +
                "3) Вывод делителей числа" +
                "4)Выйти из программы ");
            int a = Convert.ToInt32(Console.ReadLine());
            while (a != 4)
            {
                if (a==1)
                {
                    ugadaychislo();
                }
                if (a== 2)
                {
                    tabl();
                }
                if (a==3)
                {
                    delitel();
                }
                static void ugadaychislo() //игра угадай число
                {
                    int chislo = 0;
                    Random ch = new Random();
                    int sekret = ch.Next(101);
                    Console.WriteLine("Теперь отгадывай число");
                    while (true)
                    {
                        chislo = Convert.ToInt32(Console.ReadLine());
                        if (chislo == sekret)
                        {
                            Console.WriteLine("Ви, ты потрясающе везучь, ты блин угадал!");
                            break;
                        }
                        if (chislo > sekret)
                        {
                            Console.WriteLine("Куда лезешь, умерь аппититы, меньше давай!");
                        }
                        if (chislo < sekret)
                        {
                            Console.WriteLine("Эээээ! Чё так мало, а? Повышай ставки!");
                        }
                    }
                }//игра закончилась
                static void tabl()//таблица умножения
                {
                    var table = new int[10, 10];
                    for (int i = 0; i < 10; ++i)
                    {
                        for (int j = 0; j < 10; ++j)
                        {
                            table[i, j] = i * j;
                        }
                    }
                    for (int i = 0; i < 10; ++i)
                    {
                        for (int j = 0; j < 10; ++j)
                        {
                            Console.Write("{0, 3}", table[i, j]);
                        }
                        Console.WriteLine();
                    }
                } //зАКОНЧЕНО
                static void delitel()//Вывод делителей числа
                {
                    Console.Write("Введи число ");
                    int i = Convert.ToInt32(Console.ReadLine());
                    for (int a = 1; a <= i / a; a++)
                    {
                        if (i % a == 0)
                        {
                            if (a != i / a) Console.Write("{0} {1} ", a, i / a);
                            else Console.Write("{0} ", a);
                        }
                    }
                }
                if (a == 4)
                {
                    break;
                }
                a = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}