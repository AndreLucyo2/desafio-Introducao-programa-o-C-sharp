using System;

// Dividindo X por Y

/*
Você terá o desafio de escrever um algoritmo que leia 2 números e imprima
o resultado da divisão do primeiro pelo segundo. Caso não for possível mostre
a mensagem “divisao impossivel” para os valores em questão.
- Entrada
A entrada contém um número inteiro N. Este N será a quantidade de pares de
valores inteiros (X e Y) que serão lidos em seguida.
- Saída
Para cada caso mostre o resultado da divisão com um dígito após o ponto
decimal, ou “divisao impossivel” caso não seja possível efetuar o cálculo.
*/


namespace desafio_Introducao_programacao_C_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            DividirXporY();
        }

        public static void DividirXporY()
        {
            Console.Write("Informe o número de operações: ");
            int limit = Int32.Parse(Console.ReadLine());

            if (limit > 0)
            {
                for (int i = 0; i < limit; i++)
                {
                    Console.WriteLine($"{i + 1}° Divisao:");
                    string[] line = Console.ReadLine().Split(' ');
                    double X = double.Parse(line[0]);
                    double Y = double.Parse(line[1]);

                    if (Y == 0)
                    {
                        Console.WriteLine("divisao impossivel");
                    }
                    else
                    {
                        double divisao = X / Y; // Digite aqui o calculo da divisao

                        if (divisao < 0 && (divisao.ToString("N1") == "0.0"))
                        {
                            Console.WriteLine("-0.0");
                        }
                        else
                        {
                            Console.WriteLine($"Resultado {X} / {Y} = {divisao.ToString("N1")}");
                        }

                    }
                }
            }

            Console.ReadKey();
        }
    }
}
