using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora1
{
    internal class Program
    {
        enum Menu { Soma = 1, Subtracao, Divisao, Multiplicacao, Potencia, Raiz, Sair }
        static void Main(string[] args)

        {
            bool escolheusair = false;
            while (!escolheusair)
            {
                Console.WriteLine("Seja bem vindo a Calculadora do Pedrinho  , Selcione uma das opcoes");
                Console.WriteLine("1-Soma\n2-Subtração\n3-Divisão\n4-Multiplicação\n5-Potência\n6-Raiz\n7-Sair");

                Menu opcao = (Menu)int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case Menu.Soma:
                        Soma();
                        break;
                    case Menu.Subtracao:
                        Sub();
                        break;
                    case Menu.Divisao:
                        Div();
                        break;
                    case Menu.Multiplicacao:
                        Mult();
                        break;
                    case Menu.Potencia:
                        Pot();
                        break;
                    case Menu.Raiz:
                        Raiz();
                        break;
                    case Menu.Sair:
                        escolheusair = true;
                        break;
                }
                Console.Clear();

            }

        }
        static void Soma()
        {
            Console.WriteLine("soma de dois numeros:");
            Console.WriteLine("Digite o primeiro numero");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo Numero:");
            int b = int.Parse(Console.ReadLine());
            int resultado = a + b;
            Console.WriteLine($" O resultado é : {resultado}");
            Console.WriteLine("Aperte ENTER para voltar para o menu");
            Console.ReadLine();
        }
        static void Sub()
        {
            Console.WriteLine("Subtração de dois numeros:");
            Console.WriteLine("Digite o primeiro numero");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo Numero:");
            int b = int.Parse(Console.ReadLine());
            int resultado = a - b;
            Console.WriteLine($" O resultado é : {resultado}");
            Console.WriteLine("Aperte ENTER para voltar para o menu");
            Console.ReadLine();
        }
        static void Div()
        {
            Console.WriteLine("Divisão de dois numeros:");
            Console.WriteLine("Digite o primeiro numero");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo Numero:");
            int b = int.Parse(Console.ReadLine());
            float resultado = (float)a / (float)b;
            Console.WriteLine($" O resultado é : {resultado}");
            Console.WriteLine("Aperte ENTER para voltar para o menu");
            Console.ReadLine();
        }
        static void Mult()
        {
            Console.WriteLine("Multiplicação de dois numeros:");
            Console.WriteLine("Digite o primeiro numero");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo Numero:");
            int b = int.Parse(Console.ReadLine());
            int resultado = a * b;
            Console.WriteLine($" O resultado é : {resultado}");
            Console.WriteLine("Aperte ENTER para voltar para o menu");
            Console.ReadLine();
        }
        static void Pot()
        {
            Console.WriteLine("Potencia de dois numeros:");
            Console.WriteLine("Digite o primeiro numero");
            int baseNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo Numero:");
            int expo = int.Parse(Console.ReadLine());
            double resultado = (double)Math.Pow(baseNum, expo);
            Console.WriteLine($" O resultado é : {resultado}");
            Console.WriteLine("Aperte ENTER para voltar para o menu");
            Console.ReadLine();
        }
        static void Raiz()
        {
            Console.WriteLine("Raiz de um numero:");
            Console.WriteLine("Digite o Numero");
            int a = int.Parse(Console.ReadLine());
            int resultado =(int) Math.Sqrt(a);
            Console.WriteLine($" O resultado é : {resultado}");
            Console.WriteLine("Aperte ENTER para voltar para o menu");
            Console.ReadLine();

        }
    }

}
