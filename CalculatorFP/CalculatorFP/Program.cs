// See https://aka.ms/new-console-template for more information

class Program //Калькулятор версии 1, без применения функционального программирования
{
    static void Main(string[] args)
    {
        double firstvalue, twovalue; //Объявляем переменным тип данных (Данные)
        string operatorV;

        //Запрашиваем значения и метод операции (Действия, так как человек вводит значения)
        Console.WriteLine("Введите первое значение:");
        firstvalue = Double.Parse(Console.ReadLine());
        long factorial = Convert.ToInt64(firstvalue); //Пишем переменную factorial после принятия значения firstvalue

        Console.WriteLine("Введите второе значение:");
        twovalue = Double.Parse(Console.ReadLine());

        Console.WriteLine("Выберите метод операции: +, -, *, /, %, степень, факториал");
        Console.WriteLine("Для вычисления факториала берём только первую переменную");

        operatorV = Console.ReadLine();
        
        switch (operatorV)  //Производим выбор операции и считаем (Вычисления)
        {
            case "+": // Сложение
                Console.WriteLine(Sum(firstvalue, twovalue));
                break;

            case "-": // Вычитание
                Console.WriteLine(Subtraction(firstvalue, twovalue));
                break;

            case "*": // Умножение
                Console.WriteLine(Multiplication(firstvalue, twovalue));
                break;

            case "/": // Деление
                if (firstvalue == 0) // Проверяем первую переменную на 0
                    Console.WriteLine(0);
                else if (twovalue == 0) // Проверяем вторую переменную на 0
                    Console.WriteLine(0);
                else
                    Console.WriteLine(Division(firstvalue, twovalue));
                break;

            case "%": // Процент
                Console.WriteLine(Percent(firstvalue, twovalue));
                break;

            case "степень": // Степень
                Console.WriteLine(Exponentiation(firstvalue, twovalue));
                break;

            case "факториал": // Факториал
                Console.Write("Ответ = " + Factorial(factorial));
                break;

            default:
                Console.WriteLine("Неизвестная команда, повторите попытку");
                break;

        }
        Console.ReadKey();
    }

    static double Sum(double value_1,double value_2) //Функция вычисления суммы (Вычисления)
    {
        return value_1 + value_2;
    }

    static double Subtraction(double value_1, double value_2) //Функция вычисления вычитания (Вычисления)
    {
        return value_1 - value_2;
    }

    static double Multiplication(double value_1, double value_2) //Функция вычисления умножения (Вычисления)
    {
        return value_1 * value_2;
    }

    static double Division(double value_1, double value_2) //Функция вычисления деления (Вычисления)
    {
        return value_1 / value_2;
    }

    static double Percent(double value_1, double value_2) //Функция вычисления процента (Вычисления)
    {
        return value_1 * value_2 / 100;
    }

    static double Exponentiation(double value_1, double value_2) //Функция вычисления степени (Вычисления)
    {
        return Math.Pow(value_1,value_2);
    }

    static long Factorial(long value_1) //Функция вычисления факториала (Вычисления)
    {
        long factorial = 1;
        for (int i = 2; i <= value_1; i++) // Цикл начинаем с 2, т.к. нет смысла начинать с 1                   
        {
            factorial = factorial * i;
            // Console.WriteLine("Цикл for C#: итерация {0}", i); // Проверка количества итераций
        }
        return factorial ;
    }

}


