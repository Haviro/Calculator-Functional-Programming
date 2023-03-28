// See https://aka.ms/new-console-template for more information


class Program //Калькулятор версии 1, без применения функционального программирования
{
    static void Main(string[] args)
    {
        //Объявляем переменным тип данных (Данные)
        double firstvalue, twovalue;
        string operatorV;

        //Запрашиваем значения и метод операции (Действия, так как человек вводит значения)
        Console.WriteLine("Введите первое значение:");
        firstvalue = Double.Parse(Console.ReadLine());

        Console.WriteLine("Введите второе значение:");
        twovalue = Double.Parse(Console.ReadLine());

        Console.WriteLine("Выберите метод операции: +, -, *, /, %, степень, факториал");
        operatorV = Console.ReadLine();

        long factorial = Convert.ToInt64(firstvalue); // (Данные)
        factorial = 1;

        //Производим выбор операции и считаем (Вычисления)
        switch (operatorV) 
        {
            case "+": 
                Console.WriteLine(firstvalue + twovalue);
                break;

            case "-":
                Console.WriteLine(firstvalue - twovalue);
                break;

            case "*":
                Console.WriteLine(firstvalue * twovalue);
                break;

            case "/":
                if (firstvalue == 0) // Проверяем первую переменную на 0
                    Console.WriteLine(0);
                else if (twovalue == 0) // Проверяем вторую переменную на 0
                    Console.WriteLine(0);
                else
                    Console.WriteLine(firstvalue / twovalue);
                break;

            case "%":
                Console.WriteLine((firstvalue * twovalue) / 100);
                break;

            case "степень":
                Console.WriteLine(Math.Pow(firstvalue, twovalue));
                break;

            case "факториал":
                Console.WriteLine("Для вычисления факториала берём первую переменную");
                for (int i = 1; i <= firstvalue; i++) // Цикл начинаем с 2, т.к. нет смысла начинать с 1                   
                {
                    factorial = factorial * i;
                }
                    Console.WriteLine(factorial);
                break;

            default:
                Console.WriteLine("Неизвестная команда, повторите попытку");
                break;

        }
        Console.ReadKey();


    }
}


