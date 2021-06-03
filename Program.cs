using System;
using System.Collections.Generic;

namespace ControleEstoque
{
    class Program 
    {


        static void Main(string[] args)
        {        

            //Mostra todos os estoques
            for (int i = 1; i < 5; i++)
            {
                MostraEstoque(i);
                Console.WriteLine('\n');
            }

            ///Console.WriteLine("Retornou: " + QtdDeCargas);
            int QtdDeCargas = Geradores.Qtd();
            RecebeCarga(QtdDeCargas);

            Console.ReadKey();
        }

        private static void RecebeCarga(int QtdDeCargas)
        {
            for (int i = 1; i < QtdDeCargas; i++)
            {
                List<string> lista = Geradores.GeraEntrada();
                
                foreach(var item in lista)
                {
                    Console.WriteLine(item);
                    //Verficar qual estoque é o correspondente e preencher de acordo;
                    int IdItem = Convert.ToInt32(item);

                }
            }
        }


        private static void MostraEstoque(int IdEstoque)
        {
            int rowMatriz = 6;
            int colMatriz = 6;
            //Valor totall da matriz (Tamanho)
            int totalMatriz = rowMatriz * colMatriz;
            //Pega a metade da Matriz para preencher
            int metadeMatriz = MetadeMatriz(totalMatriz);

            int cont = 0;
            int[][] mtz = new int[6][];
            for (int i = 0; i < mtz.Length; i++)
            {
                mtz[i] = new int[6];
            }
            for (int i = 0; i < mtz.Length; i++)
            {
                for (int j = 0; j < mtz[i].Length; j++)
                {
                    cont = cont + 1; 

                    if (cont <= metadeMatriz)
                    {
                        mtz[i][j] = IdEstoque;
                    }
                    else
                    {
                        mtz[i][j] = 0;
                    }
                    Console.Write(mtz[i][j] + " ");
                }
                Console.WriteLine();
            }
            
        }

        private static int MetadeMatriz(int tamanhoMatriz)
        {
            int resultado = 0;

            resultado = tamanhoMatriz / 2;

            return resultado;
        }

        private static void PreencheMatriz(int IdItem)
        {

        }

    }
    }

