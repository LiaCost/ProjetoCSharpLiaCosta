using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_CSharp
{
    class Cliente
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }

        public Cliente(string nome, string cpf)
        {
            Nome = nome;
            Cpf = cpf;
        }
    }

    class Perfume
    {
        public string Nome { get; set; }
        public string Marca { get; set; }
        public decimal Preco { get; set; }

        public Perfume(string nome, string marca, decimal preco)
        {
            Nome = nome;
            Marca = marca;
            Preco = preco;
        }
    }

    class Venda
    {
        public string ClienteCpf { get; set; }
        public string PerfumeNome { get; set; }
        public string DataVenda { get; set; }
        public decimal Preco { get; set; }

        public Venda(string clienteCpf, string perfumeNome, string dataVenda, decimal preco)
        {
            ClienteCpf = clienteCpf;
            PerfumeNome = perfumeNome;
            DataVenda = dataVenda;
            Preco = preco;
        }
    }


}

