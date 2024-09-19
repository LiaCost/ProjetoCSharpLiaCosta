using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_C_
{
    public static class _08_Conversao
    {
        public static void DemonstrarConversoes()
        {
            int numInt = 100;
            long numLong = numInt;
            Console.WriteLine($"Conversão  implícita de nit para long: {numLong}");

            double numDouble = 1234.56;
            int numCast = (int)numDouble;
            Console.WriteLine($"Conversão explícita de double para int (cast): {numCast}");

            string numeroString = "456";
            int numConvert = Convert.ToInt32(numeroString);
            Console.WriteLine($"Conversão de string para int usando Convert: {numConvert}");

            string numeroString2 = "789";
            int numParse = int.Parse(numeroString2);
            Console.WriteLine($"Conversão de string para int usando Parse: {numParse}");

            string numeroInvalido = "abc";
            bool conversaoSucesso = int.TryParse(numeroInvalido, out int numTryParse);
            Console.WriteLine($"Conversão com TryParse (sucesso): {conversaoSucesso}, valor: {numTryParse}");

            object obj = 1234;
            int numUmboxed = (int)obj;
            Console.WriteLine($"Umboxing de object para int: {numUmboxed}");

            int numero = 42;
            string numString = numero.ToString();
            Console.WriteLine($"Conversão de int para string: {numeroString}");

        }
    }
}
