using System;

namespace backextra
{
    class Program
    {
        static void Main(string[] args)
        {

            int numeroAnterior = -1;
            int proximoNumero = 1;
            int resultado = 0;

            do 
            {
                resultado = numeroAnterior + proximoNumero;
                numeroAnterior = proximoNumero;
                proximoNumero = resultado;

                Console.Write(resultado + ", ");
            }while (resultado < 500);
        }
    }
}
