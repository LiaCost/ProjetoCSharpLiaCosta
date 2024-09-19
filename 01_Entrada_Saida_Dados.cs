using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_CSharp
{
    public static class Entrada_Saida_Dados
    {
        public static void LerArmazenar()
        {
           string? nome;
            Console.WriteLine("Digite o seu nome:");
            nome = Console.ReadLine();

            if (nome == null)
            {
                Console.WriteLine($"Nenhum nome foi digitado.");
            }

            else
            {
                Console.WriteLine($"O nome digitado é: {nome}");
            }
        }
    }
}
