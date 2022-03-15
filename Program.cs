double num1;
double num2;
string action;

while (true)
{
    Console.Write("Введите операцию:");
    action = Console.ReadLine();
    try
    {
        Console.Write("Введите число:");
        num1 = double.Parse(Console.ReadLine());
        Console.Write("Введите число:");
        num2 = double.Parse(Console.ReadLine());
    }
    catch (Exception)
    {
        Console.WriteLine("Неизвестное число");
        Console.Write("Нажмите, чтобы продолжить");
        Console.ReadLine();
        Console.Clear();
        continue;
    }

    
    for (int i = 0; i == 0; i++)
    {

        {
            switch (action)
            {
                case "+":
                    num1 += num2;
                    Console.WriteLine("Равно: " + num1);
                    break;
                case "-":
                    num1 -= num2;
                    Console.WriteLine("Равно: " + num1);
                    break;
                case "*":
                    num1 *= num2;
                    Console.WriteLine("Равно: " + num1);
                    break;
                case "/":
                    num1 /= num2;
                    Console.WriteLine("Равно: " + num1);
                    break;
                default:
                    Console.WriteLine("Неизвестное действие");
                    continue;
            }
        }

        while (action != "=")
        {
            Console.WriteLine("Выражение");
            action = Console.ReadLine();
            switch (action)
            {
                case "+":
                    Console.Write("Введите число:");
                    num2 = double.Parse(Console.ReadLine());
                    num1 += num2;
                    Console.WriteLine("Равно: " + num1);
                    break;
                case "-":
                    Console.Write("Введите число:");
                    num2 = double.Parse(Console.ReadLine());
                    num1 -= num2;
                    Console.WriteLine("Равно: " + num1);
                    break;
                case "*":
                    Console.Write("Введите число:");
                    num2 = double.Parse(Console.ReadLine());
                    num1 *= num2;
                    Console.WriteLine("Равно: " + num1);
                    break;
                case "/":
                    Console.Write("Введите число:");
                    num2 = double.Parse(Console.ReadLine());
                    num1 /= num2;
                    Console.WriteLine("Равно: " + num1);
                    break;
                case "=":
                    Console.WriteLine("Равно: " + num1);
                    break;
                default:
                    Console.WriteLine("Неизвестное действие");
                    break;

            }
        }
    }
    Console.Write("Нажмите, чтобы продолжить");
    Console.ReadLine();
    Console.Clear();
}


        

