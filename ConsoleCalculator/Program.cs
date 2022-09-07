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
            Console.Write("Введите первое число: ");
            
            try
            {
                firstNumber = Convert.ToInt32(Console.ReadLine());
            }
            catch 
            {
                Console.WriteLine("Неверный формат числа, повторите ввод.");
                setFirstNumber();
            }
        }

        private static void setSecondNumber()
        {
            Console.Write("Введите второе число: ");
            try
            {
                secondNumber = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Неверный формат числа, повторите ввод.");
                setSecondNumber();
            }
        }

        private static void setOprion()
        {
            Console.Write("Выберите операцию: '+', '-', '*', '/': ");
            operand = Console.ReadLine();

            if (operand.Equals("+") || operand.Equals("-") || operand.Equals("*") || operand.Equals("/")) { }
            else {
                Console.WriteLine("Неверный формат операнда, повторите ввод.");
                setOprion();
            }

        }

        private static void calculation() 
        {
            switch (operand)
            {
                case "+":
                    Console.WriteLine("Ваш результат: " + (firstNumber + secondNumber));
                    Console.WriteLine();
                    break;
                case "-":
                    Console.WriteLine("Ваш результат: " + (firstNumber - secondNumber)); 
                    Console.WriteLine();
                    break;
                case "*":
                    Console.WriteLine("Ваш результат: " + firstNumber * secondNumber);
                    Console.WriteLine();
                    break;
                case "/":
                    if (secondNumber == 0)
                    {
                        Console.WriteLine(0);
                        Console.WriteLine();
                    }
                    else
                        Console.WriteLine("Ваш результат: " + (double)firstNumber / (double)secondNumber);
                        Console.WriteLine();
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
