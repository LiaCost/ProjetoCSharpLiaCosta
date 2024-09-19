using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Curso_CSharp
{
        /* public class Carro
         {
             public string Marca;
             public string Modelo;
             public int Ano;

             public Carro(string marca, string modelo, int ano)
             {
                 this.Marca = marca;
                 this.Modelo = modelo;
                 this.Ano = ano;
             }

             public void ExibirDetalhes()
             {
                 Console.WriteLine($"A marca do carro é: {Marca} o modelo do carro é: {Modelo} e o ano do carro é: {Ano} ");
             } 


         } */

        /* public class Person
         {
             public string Nome;
             public int Idade;
             public string Cidade;

             public void ExibirInformacocoes()
             {
                 Console.WriteLine($"O nome da pessoa é: {Nome} a idade da pessoa é: {Idade} a cidade da pessoa é: {Cidade}");
             }

         } */

        public class Exercicio
        {

            public string Nome = "Liam";
            public int Idade = 21;

            public void Exibir()
            {

                Console.WriteLine($"O nome é: {Nome} a idade é: {Idade}");
            }

            public int Soma(int n1, int n2)
            {
                return n1 + n2; }

            public bool MostrarBoleano()
            { 
                bool estaChovendo = false;
              
                if ( estaChovendo == true )
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            public bool verificarMaiorIdade(int idade)
            {
                if (idade >= 18)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            public void ExibirAltura()
            {
                Double altura = 1.63;
                Console.WriteLine($"A altura é: {altura:F2}");
             
            }
            
            public double CalcularArea(double raio)
            {
              return ((raio * raio) * 3.14);
            }

            public double CalcularArea(double l, double h)
            {
              return l * h;
            }

            public void ExibirChar()
            {
                char letra = 'A';
                Console.WriteLine($"O caractere é {letra}");
            }

           
        }

        public class Calculadora
        {
            public double Multiplicar(double n1, double n2)
            {
                return (n1 * n2);
            }

            public double Multiplicar(double n1, double n2, double n3)
            {
                return (n1 * n2 *  n3); 
            }
        }

        public class FluxoLoop()
        {
              public void ExibirLoop()
              {
                  for (int i = 1; i <= 10; i++)
                  {
                    Console.WriteLine($"{i}");
                  }
              }

              public void ExibirLoopWhile()
              {
                 int contador = 10; 
                 while ( contador >= 1 ) 
                 {
                   Console.WriteLine($"contador");
                   contador--;  
                 }
              }

                public void ImprimirPares( int n )
                {
                    int contador = 1;
                    while (contador <= n)
                    {
                        if ( contador % 2 == 0 )
                        {
                          Console.WriteLine(contador);
                        }
                    }
                }


        }


}
