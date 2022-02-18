using System;

namespace Aula_Presencial_Rech.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao Soldado Bizonho!!!\n");
            

            Console.WriteLine($"\n\nOrientação inicial soldado:  N\n\n");



            while (true)
            {

                Console.WriteLine("Digite N (número de movimentos que o soldado deve fazer) ");

                int N;
                N = Convert.ToInt32(Console.ReadLine());
                if (N == 0)
                {
                    break;
                }

                if (N > 1000 || N < 0)
                {
                    Console.WriteLine("Seu N é inválido");
                }

                char Z = 'N';

                Console.WriteLine("\nInforme seus comandos ao soldado, exemplo: EDEDDEED (Digitar em CAPSLOCK) " +
                     "\n\t[E] Esquerda, [D] Direita : ");

                string a;

                

                a = Console.ReadLine().ToUpper();
                char[] ordens = a.ToCharArray();

                if (N != ordens.Length)
                {
                    Console.WriteLine("N é diferente da quantidade de comandos");
                }

                

                    for (int i = 0; i < ordens.Length; i++)
                {
                    if (ordens[i] == 'E')
                    {
                        switch (Z)
                        {
                            case 'N':
                                Z = 'O';
                                break;
                            case 'S':
                                Z = 'L';
                                break;
                            case 'L':
                                Z = 'N';
                                break;
                            case 'O':
                                Z = 'S';
                                break;
                        }
                    }
                    if (ordens[i] == 'D')
                    {
                        switch (Z)
                        {
                            case 'N':
                                Z = 'L';
                                break;
                            case 'S':
                                Z = 'O';
                                break;
                            case 'L':
                                Z = 'S';
                                break;
                            case 'O':
                                Z = 'N';
                                break;
                     
                        }




                    }
                }


                Console.WriteLine($"Orientação do soldado:  {Z}\n\n");
            }


        }
    }
}
