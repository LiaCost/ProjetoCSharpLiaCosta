using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_C_
{
    public class _09_Estrutura_Condicional
    {
        public static void DemonstrarCondicional()
        {
            // Exemplo de if-else if-else
            int numero = 25;

            if (numero > 10)
            {
                Console.WriteLine("O número é menor que 10");
            }
            else if (numero > 20)
            {
                Console.WriteLine("O número é menor que 20");
            }
            else
            {
                Console.WriteLine("\"O número é 20 ou maior");
            }


            // Exemplo de switch
            string diaSemana = "Segunda-Feira";

            switch (diaSemana)
            {
                case "Segunda-Feira":
                    Console.WriteLine("Hoje é segunda-feira");
                    break;

                case "Terça-Feira":
                    Console.WriteLine("Hoje é terça-feira");
                    break;

                case "Quarta-Feira":
                    Console.WriteLine("Hoje é quarta-feria");
                    break;
                default:
                    Console.WriteLine("Não é um dia da semana reconhecido");
                    break ;

                
            }
        }
    }
}
