using System;

namespace ConsoleCalculator
{
    class Program
    {
        private static bool closeCalculator = true;
        private static int firstNumber;
        private static int secondNumber;
        private static string operand;
        private static string replayCalc;

        static void Main(string[] args)
        {
            startCalculator();
        }

        private static void startCalculator() 
        {
            while (closeCalculator)
            {
                calculatorIsActive();
            }
        }

        private static void calculatorIsActive() 
        {
            setFirstNumber();
            setSecondNumber();
            setOprion();
            calculation();
            setAction();
        }

        private static void setFirstNumber() 
        {
            Console.WriteLine("Введите первое число.");
            firstNumber = Convert.ToInt32(Console.ReadLine());
        }

        private static void setSecondNumber()
        {
            Console.WriteLine("Введите второе число.");
            secondNumber = Convert.ToInt32(Console.ReadLine());
        }

        private static void setOprion()
        {
            Console.WriteLine("Выберите операцию: '+', '-', '*', '/'.");
            operand = Console.ReadLine();
        }

        private static void calculation() 
        {
            switch (operand)
            {
                case "+":
                    Console.WriteLine(firstNumber + secondNumber);
                    break;
                case "-":
                    Console.WriteLine(firstNumber - secondNumber);
                    break;
                case "*":
                    Console.WriteLine(firstNumber * secondNumber);
                    break;
                case "/":
                    if (secondNumber == 0)
                        Console.WriteLine(0);
                    else
                        Console.WriteLine((double)firstNumber / (double)secondNumber);
                    break;
            }
        }

        private static void setAction()
        {
            Console.WriteLine("Введите: \"Y\" - если хотите продолжить, \"N\" - если хотите выйти.");
            replayCalc = Console.ReadLine();

            if (replayCalc == "y" || replayCalc == "Y")
                closeCalculator = true;
            else if (replayCalc == "n" || replayCalc == "N")
                closeCalculator = false;
            else
            {
                Console.WriteLine("Выбрана неверная опция, повторите ввод.");
                setAction();
            }
        }
    }
}
