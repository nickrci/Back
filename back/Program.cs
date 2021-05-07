using System;

namespace back
{
    class Program
    {
        static void Main(string[] args)




        {
            bool respostaCorreta = false;
            

            while (respostaCorreta == false)
            {
                    Console.Write("\nInsira uma nota entre 0 e 10: ");
                    int nota = int.Parse(Console.ReadLine());
                    
            //    Console.WriteLine("\nNota invalida, insira outra nota");
                

                if (nota >= 0 && nota <= 10)
                {

                    Console.WriteLine("\nNota válida\n");

                    respostaCorreta = true;
                     Console.WriteLine("Fim da execução\n");
                }
                else
            {
                   Console.WriteLine("\nNota inválida\ninsira outra nota");

                }
            }
        }
    }
}