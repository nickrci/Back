using System;

namespace back
{
    class Program
    {
        static void Main(string[] args)




        {
            bool respostaCorreta = false;

            Console.Write("\ninsira um usuário: ");
            string usuario = Console.ReadLine();

            Console.Write("\ninsira uma senha diferente do usuário: ");
            string senha = Console.ReadLine();


            if (senha != usuario)
            {

                Console.WriteLine("\nCadastrado!!!\n");

                respostaCorreta = true;
                Console.WriteLine("Fim da execução\n");
            }
            else
            {
                while (respostaCorreta == false)
                {
                    Console.Write("\nSenha Invalida. Insira uma outra senha: ");
                    string senhaNova = Console.ReadLine();
                    {
                        if (senhaNova != usuario)
                            respostaCorreta = true;
                    }

                    //    Console.WriteLine("\nNota invalida, insira outra nota");


                }
                {
                    Console.WriteLine("\nSenha cadastrada. Obrigado !!!\n");
                    Console.WriteLine("Fim do programa!!!\n");

                }
            }
        }
    }
}