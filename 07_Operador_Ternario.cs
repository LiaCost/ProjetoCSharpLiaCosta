using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_CSharp
{
    public class _07_Operador_Ternario
    {
        public static void DemonstrarTernario()
        {
            int a = 10;
            int b = 20;

            // Usandoo operador ternário para encontrar o maior valor entre a e b
            int maior = (a > b) ? a : b;
            
            Console.WriteLine($"O maior valor entre {a} e {b} é: {maior}");

                  /*  if (a > b)
                    {
                        Console.WriteLine(a);
                    }
                    else
                    {
                        Console.WriteLine(b);
                    }
                  */

            // Outro exemplo: Verificar se um número é par ou impar
            int numero = 15;
            string resultado = (numero % 2 == 0) ? "par" : "impar";

            Console.WriteLine($"O número {numero} é {resultado}");

                  /*  if (numero % 2 == 0)
                    {
                        Console.WriteLine("par");
                    }
                    else
                    {
                        Console.WriteLine("impar");
                    }
                  */

            // Exemplo com uma string: Verificar se um nome está vazio 
            string nome = "";
            string mensagem = (!string.IsNullOrEmpty(nome)) ? "Nome válido" : "Nome inválido";

            Console.WriteLine(mensagem);

        }
    }
}
