using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Curso_CSharp
{
    public class Exercicios1
    {
        //Modifique o método LerArmazenar para armazenar
        //o sobrenome do usuário e exibi-lo junto com o nome:
        /* public static void LerArmazenar()
                {
                    string? nome;
                    string? sobrenome;

                    Console.WriteLine("Digite o seu nome:");
                    nome = Console.ReadLine();

                    Console.WriteLine("Digite o seu sobrenome:");
                    sobrenome = Console.ReadLine();

                    Console.WriteLine($"O nome é: {nome}  {sobrenome}");
                }*/

        // Peça ao usuário para inserir a idade e exiba o nome e a idade:
        /*  public static void LerArmazenar()
          {
              string? nome;
              int idade;

              Console.WriteLine("Digite o seu nome:");
              nome = Console.ReadLine();

              Console.WriteLine("Digite sua idade:");
              idade = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine($"O nome é: {nome}, e a idade é: {idade}");
          }*/


        // Peça ao usuário para inserir a cidade e exiba o nome e a cidade:
        /* public static void LerArmazenar()
           {
               string? cidade;
               Console.WriteLine("Digite o nome da cidade:");
               cidade = Console.ReadLine();
               Console.WriteLine($"A cidade é: {cidade}");
           }
        */

        // Armazene o nome do usuário em maiúsculas e exiba-o:
        /* public static void LerArmazenar()
           {
               string? nome;
               string? nomeMaiusculas;

               Console.Write("Digite seu nome: ");
               nome = Console.ReadLine();

               nomeMaiusculas = nome.ToUpper();
               Console.WriteLine("Nome em maiúsculas: " + nomeMaiusculas);
           }*/

        // Armazene o nome do usuário em minúsculas e exiba-o:
        /*   string? nome;
             Console.WriteLine("Digite o seu nome:");
             nome = Console.ReadLine().ToLower();
             Console.WriteLine($"O nome e: {nome}"); */


        //Peça ao usuário para inserir seu nome e idade, depois exiba ambos em uma única linha:

        /*   string? nome;
           int? idade;
           Console.WriteLine("Digite o seu nome:");
           nome = Console.ReadLine();
           Console.WriteLine("Digite sua idade:");
           idade = Convert.ToInt32(Console.ReadLine());
           Console.WriteLine($"{nome} {idade}"); */


        // Peça ao usuário para inserir seu nome e cidade de nascimento, depois exiba ambos:

        /* string? nome;
         string? cidade;
         Console.WriteLine("Digite o seu nome:");
         nome = Console.ReadLine();
         Console.WriteLine("Digite sua cidade:");
         cidade = Console.ReadLine();
         Console.WriteLine($"O nome e: {nome} e a cidade de nascimento e {cidade}"); */

        // Peça ao usuário para inserir seu nome e profissão, depois exiba ambos:

        /* string? nome;
         string? profissao;
         Console.WriteLine("Digite o seu nome:");
         nome = Console.ReadLine();
         Console.WriteLine("Digite sua profissao:");
         profissao = Console.ReadLine();
         Console.WriteLine($"O nome e: {nome} e a profissao e {profissao}"); */


        // Peça ao usuário para inserir seu nome e país de origem, depois exiba ambos:

        /* string? nome;
         string? pais;
         Console.WriteLine("Digite o seu nome:");
         nome = Console.ReadLine();
         Console.WriteLine("Digite seu pais de origem:");
         pais = Console.ReadLine();
         Console.WriteLine($"O nome e: {nome} e o pais de origem e {pais}"); */


        // Peça ao usuário para inserir seu nome e número favorito, depois exiba ambos:

        /* string? nome;
        int? numero;
        Console.WriteLine("Digite o seu nome:");
        nome = Console.ReadLine();
        Console.WriteLine("Digite seu numero favorito:");
        numero = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"O nome e: {nome} e o numero favorito e {numero}"); */


        // Peça ao usuário para inserir seu nome e hobby favorito, depois exiba ambos:

        /* string? nome;
        string? hobby;
        Console.WriteLine("Digite o seu nome:");
        nome = Console.ReadLine();
        Console.WriteLine("Digite seu hobby:");
        hobby = Console.ReadLine();
        Console.WriteLine($"O nome e: {nome} e o hobby e {hobby}"); */


        // Peça ao usuário para inserir seu nome e cor favorita, depois exiba ambos:

        /* string? nome;
         string? cor;
         Console.WriteLine("Digite o seu nome:");
         nome = Console.ReadLine();
         Console.WriteLine("Digite a cor:");
         cor = Console.ReadLine();
         Console.WriteLine($"O nome e: {nome} e a cor favorita e {cor}"); */


        // Peça ao usuário para inserir seu nome e filme favorito, depois exiba ambos:

        /* string? nome;
         string? filme;
         Console.WriteLine("Digite o seu nome:");
         nome = Console.ReadLine();
         Console.WriteLine("Digite o filme:");
         filme = Console.ReadLine();
         Console.WriteLine($"O nome e: {nome} e o filme favorito e {filme}"); */


        // Peça ao usuário para inserir seu nome e gênero musical favorito, depois exiba ambos:

        /*  string? nome;
          string? genero;
          Console.WriteLine("Digite o seu nome:");
          nome = Console.ReadLine();
          Console.WriteLine("Digite o genero musical:");
          genero = Console.ReadLine();
          Console.WriteLine($"O nome e: {nome} e o genero musical favorito e {genero}"); */

        //  Peça ao usuário para inserir seu nome e animal favorito, depois exiba ambos:

        /* string? nome;
         string? animal;
         Console.WriteLine("Digite o seu nome:");
         nome = Console.ReadLine();
         Console.WriteLine("Digite o nome do animal:");
         animal = Console.ReadLine();
         Console.WriteLine($"O nome e: {nome} e o animal favorito e {animal}"); */


        //  Peça ao usuário para inserir seu nome e esporte favorito, depois exiba ambos:

        /* string? nome;
           string? esporte;
           Console.WriteLine("Digite o seu nome:");
           nome = Console.ReadLine();
           Console.WriteLine("Digite o nome do esporte:");
           esporte = Console.ReadLine();
           Console.WriteLine($"O nome e: {nome} e o esporte favorito e {esporte}"); */

        // Peça ao usuário para inserir seu nome e comida favorita, depois exiba ambos:

        /*   string? nome;
           string? comida;
           Console.WriteLine("Digite o seu nome:");
           nome = Console.ReadLine();
           Console.WriteLine("Digite o nome da comida:");
           comida = Console.ReadLine();
           Console.WriteLine($"O nome e: {nome} e a comida favorita e {comida}"); */

        // Peça ao usuário para inserir seu nome e banda favorita, depois exiba ambos:

        /*  string? nome;
          string? banda;
          Console.WriteLine("Digite o seu nome:");
          nome = Console.ReadLine();
          Console.WriteLine("Digite o nome da banda:");
          banda = Console.ReadLine();
          Console.WriteLine($"O nome e: {nome} e a banda favorita e {banda}"); */


        // Peça ao usuário para inserir seu nome e livro favorito, depois exiba ambos:

        /*   string? nome;
           string? livro;
           Console.WriteLine("Digite o seu nome:");
           nome = Console.ReadLine();
           Console.WriteLine("Digite o nome do livro:");
           livro = Console.ReadLine();
           Console.WriteLine($"O nome e: {nome} e o livro favorito e {livro}"); */

        // Peça ao usuário para inserir seu nome e um lema de vida, depois exiba ambos:

        /*  string? nome;
            string? lema;
            Console.WriteLine("Digite o seu nome:");
            nome = Console.ReadLine();
            Console.WriteLine("Digite um lema de vida:");
            lema = Console.ReadLine();
            Console.WriteLine($"O nome e: {nome} e o lema de vida e {lema}"); */

        // OPERADORES ARTIMETICOS

        // Crie um programa em C# que solicite ao usuário dois números inteiros e calcule a soma desses números.
        // Exiba o resultado com uma mensagem que informe a soma dos dois números.
        /*   public static void LerArmazenar()
           {
               Console.Write("Digite o primeiro número: ");
               int num1 = int.Parse(Console.ReadLine());

               Console.Write("Digite o segundo número: ");
               int num2 = int.Parse(Console.ReadLine());

               int soma = num1 + num2;
               Console.WriteLine($"A soma de {num1} e {num2} é {soma}.");
           } */

        // Peça ao usuário para inserir dois números inteiros e calcule a diferença entre o primeiro e o segundo número.
        // Exiba o resultado com uma mensagem que informe a subtração.
        /* public static void LerArmazenar()
         {
             Console.Write("Digite o primeiro número: ");
             int num1 = int.Parse(Console.ReadLine());

             Console.Write("Digite o segundo número: ");
             int num2 = int.Parse(Console.ReadLine());

             int diferenca = num1 - num2;
             Console.WriteLine($"A diferença entre {num1} e {num2} é {diferenca}.");
         } */


        //Solicite ao usuário para inserir dois números inteiros e calcule a multiplicação desses números.
        //Exiba o resultado com uma mensagem que informe a multiplicação.
        /* public static void LerArmazenar()
         {
             Console.Write("Digite o primeiro número: ");
             int num1 = int.Parse(Console.ReadLine());

             Console.Write("Digite o segundo número: ");
             int num2 = int.Parse(Console.ReadLine());

             int multiplicacao = num1 * num2;
             Console.WriteLine($"A multiplicação de {num1} e {num2} é {multiplicacao}.");
         } */

        //Peça ao usuário para inserir dois números inteiros e calcule a divisão do primeiro número pelo segundo.
        //Exiba o resultado com uma mensagem que informe a divisão. Inclua tratamento para divisão por zero.
        /* public static void LerArmazenar()
         {
             Console.Write("Digite o primeiro número: ");
             int num1 = int.Parse(Console.ReadLine());

             Console.Write("Digite o segundo número: ");
             int num2 = int.Parse(Console.ReadLine());

             if (num2 == 0)
             {
                 Console.WriteLine("Divisão por zero não é permitida.");
             }
             else
             {
                 double divisao = (double)num1 / num2;
                 Console.WriteLine($"A divisão de {num1} por {num2} é {divisao}.");
             }
         } */

        //  Solicite ao usuário para inserir dois números inteiros e calcule o resto da divisão do primeiro número pelo segundo.
        //  Exiba o resultado com uma mensagem que informe o resto da divisão.
        /* public static void LerArmazenar()
         {
             Console.Write("Digite o primeiro número: ");
             int num1 = int.Parse(Console.ReadLine());

             Console.Write("Digite o segundo número: ");
             int num2 = int.Parse(Console.ReadLine());

             int resto = num1 % num2;
             Console.WriteLine($"O resto da divisão de {num1} por {num2} é {resto}.");
         } */

        // Peça ao usuário para inserir um número inteiro e, em seguida, exiba o número incrementado em 1. Utilize o operador de incremento ++.
        /* public static void LerArmazenar()
         {
             Console.Write("Digite um número inteiro: ");
             int num = int.Parse(Console.ReadLine());

             num++;
             Console.WriteLine($"O número incrementado em 1 é {num}.");
         } */

        //  Solicite ao usuário para inserir um número inteiro e exiba o mesmo número decrementado em 1. Utilize o operador de decremento --.
        /*  public static void LerArmazenar()
          {
              Console.Write("Digite um número inteiro: ");
              int num = int.Parse(Console.ReadLine());

              num--;
              Console.WriteLine($"O número decrementado em 1 é {num}.");
          } */

        //Crie um programa que solicite ao usuário para inserir dois números inteiros e calcule a média desses números.
        //Exiba a média com uma mensagem informativa.
        /*     public static void LerArmazenar()
             {
                 Console.Write("Digite o primeiro número: ");
                 int num1 = int.Parse(Console.ReadLine());

                 Console.Write("Digite o segundo número: ");
                 int num2 = int.Parse(Console.ReadLine());

                 double media = (num1 + num2) / 2.0;
                 Console.WriteLine($"A média de {num1} e {num2} é {media}.");
             } */

        // Peça ao usuário para inserir três números inteiros e calcule a soma dos dois primeiros números e, em seguida,
        // subtraia o terceiro número do resultado. Exiba o resultado com uma mensagem explicativa.
        /*    public static void LerArmazenar()
            {
                Console.Write("Digite o primeiro número: ");
                int num1 = int.Parse(Console.ReadLine());

                Console.Write("Digite o segundo número: ");
                int num2 = int.Parse(Console.ReadLine());

                Console.Write("Digite o terceiro número: ");
                int num3 = int.Parse(Console.ReadLine());

                int resultado = (num1 + num2) - num3;
                Console.WriteLine($"O resultado da soma dos dois primeiros números menos o terceiro é {resultado}.");
            } */

        // Solicite ao usuário dois números inteiros e calcule o quadrado do primeiro número somado ao segundo número.
        // Exiba o resultado com uma mensagem explicativa.
        /*   public static void LerArmazenar()
           {
               Console.Write("Digite o primeiro número: ");
               int num1 = int.Parse(Console.ReadLine());

               Console.Write("Digite o segundo número: ");
               int num2 = int.Parse(Console.ReadLine());

               int resultado = (num1 * num1) + num2;
               Console.WriteLine($"O quadrado de {num1} somado a {num2} é {resultado}.");
           } */


        //Crie um programa que solicite ao usuário para inserir um valor e exiba o dobro desse valor e a metade desse valor.
        //Utilize operadores aritméticos para fazer os cálculos.
        /*   public static void LerArmazenar()
           {
               Console.Write("Digite um valor: ");
               double valor = double.Parse(Console.ReadLine());

               double dobro = valor * 2;
               double metade = valor / 2;

               Console.WriteLine($"O dobro de {valor} é {dobro}.");
               Console.WriteLine($"A metade de {valor} é {metade}.");
           } */

        //Peça ao usuário para inserir dois números inteiros e calcule o resultado da expressão (a + b) * (a - b).
        //Exiba o resultado com uma mensagem informativa.
        /*   public static void LerArmazenar()
           {
               Console.Write("Digite o primeiro número (a): ");
               int a = int.Parse(Console.ReadLine());

               Console.Write("Digite o segundo número (b): ");
               int b = int.Parse(Console.ReadLine());

               int resultado = (a + b) * (a - b);
               Console.WriteLine($"O resultado da expressão (a + b) * (a - b) é {resultado}.");
           } */


        // Solicite ao usuário para inserir dois números inteiros e calcule a soma do quadrado do primeiro número com o quadrado do segundo número.
        // Exiba o resultado com uma mensagem explicativa.
        /*    public static void LerArmazenar()
            {
                Console.Write("Digite o primeiro número: ");
                int num1 = int.Parse(Console.ReadLine());

                Console.Write("Digite o segundo número: ");
                int num2 = int.Parse(Console.ReadLine());

                int resultado = (num1 * num1) + (num2 * num2);
                Console.WriteLine($"A soma dos quadrados de {num1} e {num2} é {resultado}.");
            } */

        //Crie um programa que solicite ao usuário para inserir um número inteiro e calcule o valor do número ao cubo.
        //Exiba o resultado com uma mensagem explicativa.
        /*    public static void LerArmazenar()
            {
                Console.Write("Digite um número inteiro: ");
                int num = int.Parse(Console.ReadLine());

                int cubo = num * num * num;
                Console.WriteLine($"O valor de {num} ao cubo é {cubo}.");
            } */

        //Peça ao usuário para inserir dois números inteiros e calcule o resultado da expressão a * (b + a) / b.
        //Exiba o resultado com uma mensagem informativa.
        /*     public static void LerArmazenar()
             {
                 Console.Write("Digite o primeiro número (a): ");
                 int a = int.Parse(Console.ReadLine());

                 Console.Write("Digite o segundo número (b): ");
                 int b = int.Parse(Console.ReadLine());

                 if (b == 0)
                 {
                     Console.WriteLine("Divisão por zero não é permitida.");
                 }
                 else
                 {
                     double resultado = a * (b + a) / (double)b;
                     Console.WriteLine($"O resultado da expressão a * (b + a) / b é {resultado}.");
                 }
             } */

        //Solicite ao usuário para inserir um número inteiro e calcule o quadrado da diferença entre o número e 5.
        //Exiba o resultado com uma mensagem explicativa.
        /*    public static void LerArmazenar()
            {
                Console.Write("Digite um número inteiro: ");
                int num = int.Parse(Console.ReadLine());

                int resultado = (num - 5) * (num - 5);
                Console.WriteLine($"O quadrado da diferença entre {num} e 5 é {resultado}.");
            } */

        //Crie um programa que solicite ao usuário dois números inteiros e calcule a média aritmética entre eles.
        //Exiba a média com uma mensagem explicativa.
        /*   public static void LerArmazenar()
           {
               Console.Write("Digite o primeiro número: ");
               int num1 = int.Parse(Console.ReadLine());

               Console.Write("Digite o segundo número: ");
               int num2 = int.Parse(Console.ReadLine());

               double media = (num1 + num2) / 2.0;
               Console.WriteLine($"A média aritmética entre {num1} e {num2} é {media}.");
           } */

        //Peça ao usuário para inserir um valor em reais e calcule o valor em dólares, assumindo uma taxa de câmbio fixa de 5.0 reais por dólar.
        //Exiba o resultado com uma mensagem explicativa.
        /*   public static void LerArmazenar()
             {
                 Console.Write("Digite o valor em reais: ");
                 double reais = double.Parse(Console.ReadLine());

                 const double taxaCambio = 5.0; // Taxa de câmbio fixa de 5 reais por dólar
                 double dolares = reais / taxaCambio;

                 Console.WriteLine($"O valor de {reais} reais é equivalente a {dolares} dólares.");
             } */

        //Solicite ao usuário para inserir a quantidade de dias e calcule a quantidade total de horas.
        //Exiba o resultado com uma mensagem explicativa.
        /*   public static void LerArmazenar()
             {
                 Console.Write("Digite a quantidade de dias: ");
                 int dias = int.Parse(Console.ReadLine());

                 int horas = dias * 24; // 1 dia = 24 horas

                 Console.WriteLine($"A quantidade total de horas em {dias} dias é {horas} horas.");
             } */

        //Crie um programa que peça ao usuário para inserir a quantidade de horas e minutos e calcule o total em minutos.
        //Exiba o resultado com uma mensagem explicativa.
        /*  public static void LerArmazenar()
            {
                Console.Write("Digite a quantidade de horas: ");
                int horas = int.Parse(Console.ReadLine());

                Console.Write("Digite a quantidade de minutos: ");
                int minutos = int.Parse(Console.ReadLine());

                int totalMinutos = (horas * 60) + minutos; // 1 hora = 60 minutos

                Console.WriteLine($"O total de minutos é {totalMinutos} minutos.");
            } */

    }
}
