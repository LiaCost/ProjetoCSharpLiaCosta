using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_C_
{
    public class VarUsageExample
    {
        public void DemonstrateVarUsage()
        {
            // Exemplo 1: Inferência de Tipo
            var NumeroInteiro = 42; // O compilador infere que o tipo é int
            var NumeroReal = 3.14; // O compilador infere que o tipo é double
            var comprimento = "Hello, World!"; // O compilador infere que o tipo é string

            Console.WriteLine($"NumeroInteiro: {NumeroInteiro}, Type: {NumeroInteiro.GetType()}");
            Console.WriteLine($"NumeroReal: {NumeroReal}, Type: {NumeroReal.GetType()}");
            Console.WriteLine($"Comprimento: {comprimento}, Type: {comprimento.GetType()}");

            // Exemplo 2: Inferência com Tipos Complexos
            var pessoa = new Pessoa { Nome = "Alice", Idade = 30 }; // O compilador infere o tipo como Person

            Console.WriteLine($"Nome da pessoa: {pessoa.Nome}, Idade: {pessoa.Idade}");

            // Exemplo 3: Uso com Coleções
            var numeros = new int[] { 1, 2, 3, 4, 5 }; // O compilador infere o tipo como int[]
            var nomes = new List<string> { "Alice", "Bob", "Charlie" }; // O compilador infere o tipo como List<string>

            Console.WriteLine("Numbers:");
            foreach (var numero in numeros)
            {
                Console.WriteLine(numero);
            }

            Console.WriteLine("Names:");
            foreach (var nome in nomes)
            {
                Console.WriteLine(nome);
            }

            // Exemplo 4: Não pode ser usado sem inicialização
            // var uninitializedVar; // Isto resultará em um erro de compilação, pois o tipo não pode ser inferido sem um valor inicial

            // Exemplo 5: Uso com LINQ
            var query = from n in numeros
                        where n % 2 == 0
                        select n;

            Console.WriteLine("Números pares:");
            foreach (var numeroPar in query)
            {
                Console.WriteLine(numeroPar);
            }
        }
    }

    // Exemplo de classe usada no exemplo
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
    }

}
