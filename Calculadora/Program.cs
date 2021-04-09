using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            string opcao = "";
            double resultado = 0;
            int i = 0;
            string[] guardaOperacao = new string[100];
            double primeiroNumero = 0, segundoNumero = 0;


            while (true)
            {
                MostraMenu();

                opcao = Console.ReadLine();

                if (opcao != "1" && opcao != "2" && opcao != "3" && opcao != "4" && opcao != "5" && opcao != "S" && opcao != "s")
                {
                   // Console.Clear();
                    Console.WriteLine("Opção inválida! Tente novamente!\n");
                    continue;
                }

                else if (opcao == "5")
                {
                    if (guardaOperacao[0] == null)
                    {
                        Console.Clear();
                        Console.WriteLine("Não há operações realizadas!\n");
                        continue;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Operações Realizadas : \n");

                        for (int j = 0; j < guardaOperacao.Length; j++)
                        {

                            if (guardaOperacao[j] == null)
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Operacão " + (j+1) + " = " + guardaOperacao[j]);
                            }
                        }
                    }
                    break;
                }

                else if (opcao.Equals("s", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }

                else
                {
                    RecebeNumero(out primeiroNumero, out segundoNumero);
                    Calcula(opcao, ref resultado, ref i, guardaOperacao, primeiroNumero, segundoNumero);
                }


               //Console.Clear();


            }


            Console.ReadLine();
            Console.Clear();

        }

        private static void Calcula(string opcao, ref double resultado, ref int i, string[] guardaOperacao, double primeiroNumero, double segundoNumero)
        {
            switch (opcao)
            {

                case "1":
                    resultado = primeiroNumero + segundoNumero;
                    Console.Clear();
                    Console.WriteLine("Resultado: " + resultado + "\n");
                    guardaOperacao[i] = primeiroNumero.ToString() + "+" + segundoNumero.ToString() + "=" + resultado.ToString();
                    i++;
                    break;

                case "2":
                    resultado = primeiroNumero - segundoNumero;
                    Console.Clear();
                    Console.WriteLine("Resultado: " + resultado + "\n");
                    guardaOperacao[i] = primeiroNumero.ToString() + "-" + segundoNumero.ToString() + "=" + resultado.ToString();
                    i++;
                    break;

                case "3":
                    if (segundoNumero == 0)
                    {
                        Console.Clear();
                        Console.WriteLine("Impossível dividir por 0! \n");
                        break;
                    }

                    resultado = primeiroNumero / segundoNumero;
                    Console.Clear();
                    Console.WriteLine("Resultado: " + resultado + "\n");
                    guardaOperacao[i] = primeiroNumero.ToString() + "/" + segundoNumero.ToString() + "=" + resultado.ToString();
                    i++;
                    break;

                case "4":
                    resultado = primeiroNumero * segundoNumero;
                    Console.Clear();
                    Console.WriteLine("Resultado: " + resultado + "\n");
                    guardaOperacao[i] = primeiroNumero.ToString() + "*" + segundoNumero.ToString() + "=" + resultado.ToString();
                    i++;
                    break;


            }
        }

        private static void RecebeNumero(out double primeiroNumero, out double segundoNumero)
        {
            Console.Write("Digite o primeiro número: ");
            primeiroNumero = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            segundoNumero = Convert.ToDouble(Console.ReadLine());
        }

        private static void MostraMenu()
        {
            Console.WriteLine("Calculadora\n");
            Console.WriteLine("Digite 1 para somar");
            Console.WriteLine("Digite 2 para subtrair");
            Console.WriteLine("Digite 3 para dividir");
            Console.WriteLine("Digite 4 para multiplicar");
            Console.WriteLine("Digite 5 para mostrar as operações");
            Console.WriteLine("Digite S para sair");
        }
    }
}