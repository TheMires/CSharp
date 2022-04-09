using System;

namespace mypocketcalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string desligar = "off";

            Console.WriteLine("You're the operator in my pocket calculator");
            Console.WriteLine("Para ligar digite 'on': ");
            string ligar = Console.ReadLine();

            {
                while (ligar == "on")

                {
                    Console.Write("Digite o primeiro número: ");
                    int num1 = int.Parse(Console.ReadLine());

                    Console.Write("Digite o operador: ");
                    string operador = Console.ReadLine();

                    Console.Write("Digite o segundo número: ");
                    int num2 = int.Parse(Console.ReadLine());

                    switch (operador)
                    {
                        case "+":
                            Console.WriteLine("Resultado: " + somar(num1, num2));
                            break;
                        case "-":
                            Console.WriteLine("Resultado: " + subtrair(num1, num2));
                            break;
                        case "*":
                            Console.WriteLine("Resultado: " + multiplicar(num1, num2));
                            break;
                        case "/":
                            Console.WriteLine("Resultado: " + dividir(num1, num2));
                            break;
                    }
                    Console.WriteLine("Para desligar digite 'off', para continuar digite 'on'");
                    desligar = Console.ReadLine();

                    if (desligar != "on")
                    {
                        break;
                    }
                }
            }


        {
          Console.WriteLine("Volte mais tarde");
        }

    Console.WriteLine("Obrigado!");
        }


        public static string somar(int num1, int num2)
        {
            return (num1 + num2).ToString();
        }
        public static string subtrair(int num1, int num2)
        {
            return (num1 - num2).ToString();
        }
        public static string multiplicar(int num1, int num2)
        {
            return (num1 * num2).ToString();
        }
        public static string dividir(int num1, int num2)
        {
            if (valorDividendoMenorOuIgualAZero(num2))
            {
                return "Não é possivel dividir por zero ou menor que zero";
            }
            return (num1 / num2).ToString();
            bool valorDividendoMenorOuIgualAZero(int num2)
            {
                if (num2 <= 0)
                {
                    return true;
                }
                return false;
            }
        }
    }
}
