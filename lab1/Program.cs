internal class Program
{
    //задание 1 Методы
    public double fraction(double x)
    {
        return x % 1;
    }

    public int charToNum(char x)
    {
        return (int)x;
    }

    public bool is2Digits(int x)
    {
        return x >= 10 && x < 100;
    }

    public bool isInRange(int a, int b, int num)
    {
        return num >= Math.Min(a, b) && num <= Math.Max(a, b);
    }

    public bool isEqual(int a, int b, int c)
    {
        return a == b && b == c;
    }

    //задание 2 Условия
    public int abs(int x)
    {
        return x >= 0 ? x : -x;
    }

    public bool is35(int x)
    {
        return x % 3 == 0 || x % 5 == 0;
    }

    public int max3(int x, int y, int z)
    {
        return Math.Max(Math.Max(x, y), z);
    }

    public int sum2(int x, int y)
    {
        return (x + y >= 10 && x + y <= 19) ? 20 : x + y;
    }

    public String day(int x)
    {
        switch (x)
        {
            case 1: return "понедельник";
            case 2: return "вторник";
            case 3: return "среда";
            case 4: return "четверг";
            case 5: return "пятница";
            case 6: return "суббота";
            case 7: return "воскресенье";
            default: return "это не день недели";
        }
    }

    //задание 3 Циклы
    public String listNums(int x)
    {
        var numbers = Enumerable.Range(0, x + 1).Select(i => i.ToString()).ToList();
        return string.Join(" ", numbers);
    }

    public String chet(int x)
    {
        var evenNumbers = Enumerable.Range(0, x + 1).Where(i => i % 2 == 0).Select(i => i.ToString()).ToList();
        return string.Join(" ", evenNumbers);
    }

    public int numLen(long x)
    {
        return x.ToString().Length;
    }

    public void square(int x)
    {
        for (int i = 0; i < x; i++)
        {
            Console.WriteLine(new string('*', x));
        }
    }

    public void rightTriangle(int x)
    {
        for (int i = 0; i < x; i++)
        {
            Console.WriteLine(new string(' ', x - i - 1) + new string('*', i + 1));
        }
    }

    //задание 4 Массивы
    public int findFirst(int[] arr, int x)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == x)
            {
                return i;
            }
        }
        return -1;
    }

    public int maxAbs(int[] arr)
    {
        return arr.Max(Math.Abs);
    }

    public int[] add(int[] arr, int[] ins, int pos)
    {
        var result = new int[arr.Length + ins.Length];
        Array.Copy(arr, 0, result, 0, pos);
        Array.Copy(ins, 0, result, pos, ins.Length);
        Array.Copy(arr, pos, result, pos + ins.Length, arr.Length - pos);
        return result;
    }

    public int[] reverseBack(int[] arr)
    {
        return (int[])arr.Clone();
    }

    public int[] findAll(int[] arr, int x)
    {
        var indices = new List<int>();
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == x)
            {
                indices.Add(i);
            }
        }
        return indices.ToArray();
    }


    private static void Main(string[] args)
    {
        Program pr = new Program();
        int x, m, y, c, a;
        bool repeat = true;

        while (repeat)
        {
            Console.WriteLine("\nВыберите раздел:");
            Console.WriteLine("   1. Методы");
            Console.WriteLine("   2. Условия");
            Console.WriteLine("   3. Циклы");
            Console.WriteLine("   4. Массивы");
            Console.Write("Ваш выбор: ");

            x = Convert.ToInt32(Console.ReadLine());

            switch (x)
            {
                case 1:
                    Console.WriteLine("Введите цифру, которой нумеруется задача:\n   1. Дробная часть\n   2. Букву в число\n   3. Двузначное\n   4. Диапазон\n   5. Равенство");
                    m = Convert.ToInt32(Console.ReadLine());
                    switch (m)
                    {
                        case 1:
                            Console.WriteLine("\"Дробная часть\" - Возврат дробной части числа\n Введите вещественное число");
                            double m1;
                            m1 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine($"Результат: {pr.fraction(m1)}"); 
                            break;
                        case 2:
                            Console.WriteLine("\"Букву в число\" - Преобразование символа в число\n Введите символ (от 0 до 9)");
                            char m2;
                            m2 = Convert.ToChar(Console.ReadLine());
                            Console.WriteLine($"Результат: {pr.charToNum(m2)-48}"); 
                            break;
                        case 3:
                            Console.WriteLine("\"Двузначное\" - Проверка на двузначность числа\n Введите число");
                            int m3;
                            m3 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine($"Результат: {pr.is2Digits(m3)}"); 
                            break;
                        case 4:
                            Console.WriteLine("\"Диапазон\" - Проверка на вхождениеи числа в указанный диапазон");
                            int m4l, m4r, num;
                            Console.WriteLine("Введите левую и правую границы диаапазона и число");
                            m4l = Convert.ToInt32(Console.ReadLine());
                            m4r = Convert.ToInt32(Console.ReadLine());
                            num = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine($"Результат: {pr.isInRange(m4l, m4r, num)}"); 
                            break;
                        case 5:
                            Console.WriteLine("\"Равенство\" - Проверка равенства трех чисел\n Введите три числа");
                            int m5a, m5b, m5c;
                            m5a = Convert.ToInt32(Console.ReadLine());
                            m5b = Convert.ToInt32(Console.ReadLine());
                            m5c = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine($"Результат: {pr.isEqual(m5a, m5b, m5c)}"); 
                            break;
                        default:
                            Console.WriteLine("Неправильный выбор задачи.");
                            break;
                    }
                    break;
                case 2:
                    Console.WriteLine("Введите цифру, которой нумеруется задача:\n   1. Модуль числа\n   2. Тридцать пять\n   3. Тройной максимум\n   4. Двойная сумма\n   5. День недели");
                    y = Convert.ToInt32(Console.ReadLine());
                    switch (y)
                    {
                        case 1:
                            Console.WriteLine("\"Модуль числа\" - Возврат модуля числа\n Введите число");
                            int y1;
                            y1 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine($"Результат: {pr.abs(y1)}"); 
                            break;
                        case 2:
                            Console.WriteLine("\"Тридцать пять\" - Проверка деления нацело на 3 или 5\n Введите число");
                            int y2;
                            y2 = Convert.ToInt32(Console.ReadLine()); ;
                            Console.WriteLine($"Результат: {pr.is35(y2)}"); 
                            break;
                        case 3:
                            Console.WriteLine("\"Тройной максимум\" - Поиск максимального из трех значений\n Введите три числа");
                            int y3x, y3y, y3z;
                            y3x = Convert.ToInt32(Console.ReadLine());
                            y3y = Convert.ToInt32(Console.ReadLine());
                            y3z = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine($"Результат: {pr.max3(y3x, y3y, y3z)}"); 
                            break;
                        case 4:
                            Console.WriteLine("\"Двойная сумма\" - Возврат суммы чисел (если сумма от 10 до 19 - вернуть\n Введите два числа)");
                            int y4a, y4b;
                            y4a = Convert.ToInt32(Console.ReadLine());
                            y4b = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine($"Результат: {pr.sum2(y4a,y4b)}"); 
                            break;
                        case 5:
                            Console.WriteLine("\"День недели\"\n Введите число от 1 до 7");
                            int y5;
                            y5 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine($"Результат: {pr.day(y5)}"); 
                            break;
                        default:
                            Console.WriteLine("Неправильный выбор задачи.");
                            break;
                    }
                    break;
                case 3:
                    Console.WriteLine("Введите цифру, которой нумеруется задача:\n   1. Числа подряд\n   2. Четные числа\n   3. Длина числа\n   4. Квадрат\n   5. Правый треугольник");
                    c = Convert.ToInt32(Console.ReadLine());
                    switch (c)
                    {
                        case 1:
                            Console.WriteLine("\"Числа подряд\" - Возврат чисел от 0 до x\n Введите х");
                            int c1;
                            c1 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine($"Результат: {pr.listNums(c1)}"); 
                            break;
                        case 2:
                            Console.WriteLine("\"Четные числа\" - Возврат четных чисел от 0 до х\n Введите х");
                            int c2;
                            c2 = Convert.ToInt32(Console.ReadLine()); 
                            Console.WriteLine($"Результат: {pr.chet(c2)}"); 
                            break;
                        case 3:
                            Console.WriteLine("\"Длина числа\" - Возврат количества знаков в числе\n Введите число");
                            int c3;
                            c3 = Convert.ToInt32(Console.ReadLine()); ;
                            Console.WriteLine($"Результат: {pr.numLen(c3)}"); 
                            break;
                        case 4:
                            Console.WriteLine("\"Квадрат\" - Вывод квадрата из * размером х\n ВВедите х");
                            int c4;
                            c4 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Результат: ");
                            pr.square(c4);
                            break;
                        case 5:
                            Console.WriteLine("\"Правый треугольник\" - Вывод выравненного по правому краю трегуольника из * размера х\n Введите х");
                            int c5;
                            c5 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Результат: "); 
                            pr.rightTriangle(c5);
                            break;
                        default:
                            Console.WriteLine("Неправильный выбор задачи.");
                            break;
                    }
                    break;
                case 4:
                    Console.WriteLine("Введите цифру, которой нумеруется задача:\n   1. Поиск первого значения\n   2. Поиск максимального\n   3. Добавление массива в массив\n   4. Возвратный реверс\n   5. Все вхождения");
                    a = Convert.ToInt32(Console.ReadLine());
                    switch (a)
                    {
                        case 1:
                            Console.WriteLine("\"Поиск первого значения\" - Возврат индекса первого вхождения числа в массив\n Введите x ");
                            int a1;
                            a1 = Convert.ToInt32(Console.ReadLine());
                            int[] mas1 = new int[10];
                            Random random1 = new Random();
                            mas1[0] = random1.Next(1,10);
                            Console.WriteLine(mas1);
                            Console.WriteLine($"Результат: {pr.findFirst(mas1, a1)}");
                            break;
                        case 2:
                            Console.WriteLine("\"Поиск максимального\" - Возврат наибольшего по модулую значения массива");
                            int[] mas2 = new int[10];
                            Random random2 = new Random();
                            mas2[0] = random2.Next(1, 10);
                            Console.WriteLine(mas2);
                            Console.WriteLine($"Результат: {pr.maxAbs(mas2)}"); 
                            break;
                        case 3:
                            Console.WriteLine("\"Добавление массива в массив\" - Добавление массива х в массив у с позиции а\nВведите а");
                            int a3;
                            a3 = Convert.ToInt32(Console.ReadLine());
                            int[] mas3 = new int[5];
                            Random random3 = new Random();
                            mas3[0] = random3.Next(1, 10);
                            Console.WriteLine(mas3);
                            int[] mas32 = new int[4];
                            Random random32 = new Random();
                            mas32[0] = random32.Next(1, 10);
                            Console.WriteLine(mas32);
                            Console.WriteLine($"Результат: {pr.add(mas3,mas32,a3)}");
                            break;
                        case 4:
                            Console.WriteLine("\"Возвратный реверс\" - Вовзрат массива, в котором значения записаны задом наперед");
                            int[] mas4 = new int[10];
                            Random random4 = new Random();
                            mas4[0] = random4.Next(1, 10);
                            Console.WriteLine(mas4);
                            Console.WriteLine($"Результат: {pr.reverseBack(mas4)}"); 
                            break;
                        case 5:
                            Console.WriteLine("\"Все вхождения\" - Вывод индексов всех вхождений числа х в массив");
                            int a5;
                            int[] mas5 = new int[10];
                            Random random5 = new Random();
                            mas5[0] = random5.Next(1, 10);
                            Console.WriteLine(mas5);
                            Console.WriteLine("Введите х");
                            a5 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine($"Результат: {pr.findAll(mas5,a5)}"); 
                            break;
                        default:
                            Console.WriteLine("Неправильный выбор задачи.");
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("Выберите представленные разделы.");
                    break;
            }

            Console.WriteLine("\nХотите продолжить работу в программе? (0 - да, 1 - нет)");
            Console.Write("Ваш выбор: ");

            string continueChoice = Console.ReadLine();

            repeat = (continueChoice.ToLower() != "1");
        }
    }
}