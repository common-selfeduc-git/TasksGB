namespace TasksGB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string starter = "start";
            while (starter != "/exit")
            {
                Console.WriteLine("1. Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.");
                Console.WriteLine("2. Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.");
                Console.WriteLine("3. Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).");
                Console.WriteLine("4. Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.");
                Console.WriteLine("Для выхода пропишите /exit.");
                starter = Console.ReadLine();
                Console.Clear();
                switch (starter)
                {
                    case "1":
                        {
                            Console.Clear();
                            Console.WriteLine("Вы выбрали функцию 1. Она сравнивает два числа, которые вы должны будете ввести, и выводит результат на экран.");
                            Comparator comparator = new Comparator();
                            Console.Write("Введите первую переменную:");
                            int a = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Введите вторую переменную:");
                            int b = Convert.ToInt32(Console.ReadLine());
                            comparator.Compare(a, b);
                        };
                        break;
                    case "2":
                        {
                            Console.Clear();
                            Console.WriteLine("Вы выбрали функцию 2. Она сравнивает три переменные, которые вы должны будете ввести, и выводит результат на экран.");
                            Comparator comparator = new Comparator();
                            Console.Write("Введите первую переменную: ");
                            int a = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Введите вторую переменную: ");
                            int b = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Введите третью переменную: ");
                            int c = Convert.ToInt32(Console.ReadLine());
                            comparator.Compare(a, b, c);
                        };
                        break;
                    case "3":
                        {
                            Console.Clear();
                            Console.WriteLine("Вы выбрали функцию 3. Она определяет, является ли число, которое вы должны будете ввести, чётным.");
                            OdderOrEvener odderOrEvener = new OdderOrEvener();
                            odderOrEvener.Solve();
                        }
                        break;
                    case "4":
                        {
                            Console.Clear();
                            Console.WriteLine("Вы выбрали функцию 4. Она на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.");
                            Console.Write("Введите число: ");
                            int a = Convert.ToInt32(Console.ReadLine());
                            EvenRange evenRange = new EvenRange();
                            evenRange.Print(a);
                        }
                        break;
                    default: Console.WriteLine("Введите корректный номер функции."); 
                        break;

                    case "/exit":
                        Console.WriteLine("Успешный выход из приложения...");
                        return;
                }
                Console.WriteLine("Нажмите любую кнопку на клавиатуре, чтобы вернуться в главное меню...");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
