using Curso_C_.Paradigmas;
using Curso_CSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;


/*
 //bool resultado;
//resultado = 04_Operadores_Logicos.Elogico(false, true);
//Console.WriteLine($"O resultado do operador logico E:{resultado}");
//resultado = 04_Operadores_Logicos.OULogico(false, true);
//Console.WriteLine($"O resultado do operador logico OU:{resultado}");
//resultado = 04_Operadores_Logicos.Negacao(true);
//Console.WriteLine($"O resultado do operador logico !:{resultado}");
//resultado = 04_Operadores_Logicos.OUExclusivo(false, false);
//Console.WriteLine($"O resultado do operador logico OUExclusivo:{resultado}");
//Tipos_Primitivos.ImprimirTipos();
//Entrada_Saida_Dados.LerArmazenar();
//03_Operadores_Aritmeticos.Soma();
//03_Operadores_Aritmeticos.Subtração().
//03_Operadores_Aritmeticos.Divisão()
//03_Operadores_Aritmeticos.Multiplicação()
//03_Operadores_Aritmeticos.Incremento()
//03_Operadores_Aritmeticos.Decremento()
//Exercicios.LerArmazenar();
//Exercicios_Operadores_Aritmeticos.LerArmazenar();
// 06_Operadores_deComparacao.DemonstrarOperadores();
//Exercicio.MostrarResultado();
//Conversao.DemonstrarConversoes();
//Estrutura_deRepeticao.DemonstrarRepeticoes();
//Carro carro = new Carro("Phanton II", "Rolls Royce", 1936);
//carro.ExibirDetalhes();
//Person person = new Person();
//person.Nome = "Lia";
//person.Idade = 19;
//person.Cidade = "Brasília";
//Exercicio exercicio = new Exercicio();
//exercicio.Exibir();
//int recebeSoma = exercicio.Soma(9, 3);
//Console.WriteLine($"A soma dos dois números é: {recebeSoma}");

//bool recebeBool = exercicio.MostrarBoleano();
//Console.WriteLine($"Está chovendo? {recebeBool}");

//bool recebeBoolIdade = exercicio.verificarMaiorIdade(21);
//Console.WriteLine($"A pessoa é maior de idade? {recebeBoolIdade}");

//exercicio.ExibirAltura();

//double recebeAreaC = exercicio.CalcularArea(9.45);
//Console.WriteLine($" A areá é: {recebeAreaC:F2}");

//double recebeAreaR = exercicio.CalcularArea(9, 6);
//Console.WriteLine($" A areá é: {recebeAreaR:F2}");

//Calculadora ck = new Calculadora();
//double receberMulti2 = ck.Multiplicar(2, 3);
//Console.WriteLine($" O valorda multiplicação com dois parametros é: {receberMulti2}");
//double receberMulti3 = ck.Multiplicar(2, 3, 4);
//Console.WriteLine($" O valorda multiplicação com dois parametros é: {receberMulti3}");

//exercicio.ExibirChar(); 

//FluxoLoop fl = new FluxoLoop();
//fl.ExibirLoop();
//fl.ExibirLoopWhile();
//fl.ImprimirPares(6);

//var exaple = new VarUsageExample();
//exaple.DemonstrateVarUsage();

//var exemplo = new ExemploUsoDynamic();
//exemplo.DemonstrarUsoDynamic();

//var exemplo = new ExemploUsoLINQ();
//exemplo.DemonstrarUsoLINQ();

//var ex = new ExplicacaoEnum();
//ex.ExplicacaoDetalhada();

//var ex = new Metodos();
//ex.DemonstrarMetodos();

//Atividade atividade = new Atividade();
//atividade.ExibirResultado();

//var stru = new ExplicacaoStructs();
//stru.DemonstrarDiferenca();

//var nulo = new NullableTypesDemo();
//nulo.ExibirValores();
//nulo.ExplicarConceitos();


 */

/*
 namespace BibliotecaVeiculos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Inicialização de objetos
            Biblioteca biblioteca = new Biblioteca();
            Garagem garagem = new Garagem();
            Usuario usuario = new Usuario("João Silva", "12345678900");
            Cliente cliente = new Cliente("Maria Oliveira", "98765432100");

            // Loop do menu principal
            int opcao = 0;
            do
            {
                Console.Clear(); // Limpa a tela para uma melhor organização visual
                Console.WriteLine("==============================================");
                Console.WriteLine("==========   SISTEMA DE GERENCIAMENTO   ======");
                Console.WriteLine("==============================================\n");
                Console.WriteLine("1. Biblioteca de Livros");
                Console.WriteLine("2. Sistema de Gerenciamento de Veículos");
                Console.WriteLine("0. Sair");
                Console.WriteLine("==============================================");
                Console.Write("Escolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        MenuBiblioteca(biblioteca, usuario);
                        break;
                    case 2:
                        MenuVeiculos(garagem, cliente);
                        break;
                    case 0:
                        Console.WriteLine("\nSaindo do programa...");
                        break;
                    default:
                        Console.WriteLine("\nOpção inválida, tente novamente.");
                        break;
                }
            } while (opcao != 0);
        }

        static void MenuBiblioteca(Biblioteca biblioteca, Usuario usuario)
        {
            int opcao = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("==============================================");
                Console.WriteLine("==========   BIBLIOTECA DE LIVROS   ==========");
                Console.WriteLine("==============================================\n");
                Console.WriteLine("1. Adicionar Livro");
                Console.WriteLine("2. Listar Livros");
                Console.WriteLine("3. Emprestar Livro");
                Console.WriteLine("4. Devolver Livro");
                Console.WriteLine("5. Exibir Livros Emprestados");
                Console.WriteLine("0. Voltar");
                Console.WriteLine("==============================================");
                Console.Write("Escolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        AdicionarLivro(biblioteca);
                        break;
                    case 2:
                        biblioteca.ListarLivros();
                        break;
                    case 3:
                        EmprestarLivro(biblioteca, usuario);
                        break;
                    case 4:
                        DevolverLivro(biblioteca, usuario);
                        break;
                    case 5:
                        usuario.ExibirLivrosEmprestados();
                        break;
                    case 0:
                        Console.WriteLine("\nVoltando ao menu principal...");
                        break;
                    default:
                        Console.WriteLine("\nOpção inválida, tente novamente.");
                        break;
                }
                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey(); // Pausa para permitir que o usuário veja a mensagem antes de continuar
            } while (opcao != 0);
        }

        static void MenuVeiculos(Garagem garagem, Cliente cliente)
        {
            int opcao = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("==============================================");
                Console.WriteLine("=======   SISTEMA DE VEÍCULOS - GARAGEM   =====");
                Console.WriteLine("==============================================\n");
                Console.WriteLine("1. Adicionar Veículo");
                Console.WriteLine("2. Listar Veículos");
                Console.WriteLine("3. Comprar Veículo");
                Console.WriteLine("4. Vender Veículo");
                Console.WriteLine("5. Exibir Veículos Comprados");
                Console.WriteLine("0. Voltar");
                Console.WriteLine("==============================================");
                Console.Write("Escolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        AdicionarVeiculo(garagem);
                        break;
                    case 2:
                        ListarVeiculos(garagem);
                        break;
                    case 3:
                        ComprarVeiculo(garagem, cliente);
                        break;
                    case 4:
                        VenderVeiculo(garagem);
                        break;
                    case 5:
                        cliente.ExibirVeiculosComprados();
                        break;
                    case 0:
                        Console.WriteLine("\nVoltando ao menu principal...");
                        break;
                    default:
                        Console.WriteLine("\nOpção inválida, tente novamente.");
                        break;
                }
                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey(); // Pausa para permitir que o usuário veja a mensagem antes de continuar
            } while (opcao != 0);
        }

        static void AdicionarLivro(Biblioteca biblioteca)
        {
            Console.Clear();
            Console.WriteLine("==============================================");
            Console.WriteLine("=========   ADICIONAR NOVO LIVRO   ==========");
            Console.WriteLine("==============================================");
            Console.Write("Digite o título do livro: ");
            string titulo = Console.ReadLine();
            Console.Write("Digite o autor do livro: ");
            string autor = Console.ReadLine();
            Console.Write("Digite o ano de publicação: ");
            int ano = int.Parse(Console.ReadLine());
            Console.Write("Digite o número de páginas: ");
            int paginas = int.Parse(Console.ReadLine());

            Livro livro = new Livro(titulo, autor, ano, paginas);
            biblioteca.AdicionarLivro(livro);
            Console.WriteLine("\nLivro adicionado com sucesso!");
        }

        static void EmprestarLivro(Biblioteca biblioteca, Usuario usuario)
        {
            Console.Clear();
            Console.WriteLine("==============================================");
            Console.WriteLine("==========   EMPRÉSTIMO DE LIVRO   ==========");
            Console.WriteLine("==============================================");
            Console.Write("Digite o título do livro a ser emprestado: ");
            string titulo = Console.ReadLine();
            Livro livro = biblioteca.BuscarLivroPorTitulo(titulo);
            if (livro != null)
            {
                usuario.EmprestarLivro(livro, biblioteca);
                Console.WriteLine("\nLivro emprestado com sucesso!");
            }
            else
            {
                Console.WriteLine("\nLivro não encontrado no acervo.");
            }
        }

        static void DevolverLivro(Biblioteca biblioteca, Usuario usuario)
        {
            Console.Clear();
            Console.WriteLine("==============================================");
            Console.WriteLine("===========   DEVOLUÇÃO DE LIVRO   ===========");
            Console.WriteLine("==============================================");
            Console.Write("Digite o título do livro a ser devolvido: ");
            string titulo = Console.ReadLine();
            Livro livro = biblioteca.BuscarLivroPorTitulo(titulo);
            if (livro != null)
            {
                usuario.DevolverLivro(livro, biblioteca);
                Console.WriteLine("\nLivro devolvido com sucesso!");
            }
            else
            {
                Console.WriteLine("\nLivro não encontrado na lista de empréstimos.");
            }
        }

        static void AdicionarVeiculo(Garagem garagem)
        {
            Console.Clear();
            Console.WriteLine("==============================================");
            Console.WriteLine("=========   ADICIONAR NOVO VEÍCULO   =========");
            Console.WriteLine("==============================================");
            Console.Write("Digite a marca do veículo: ");
            string marca = Console.ReadLine();
            Console.Write("Digite o modelo do veículo: ");
            string modelo = Console.ReadLine();
            Console.Write("Digite o ano do veículo: ");
            int ano = int.Parse(Console.ReadLine());
            Console.Write("Digite a quilometragem do veículo: ");
            int quilometragem = int.Parse(Console.ReadLine());

            Veiculo veiculo = new Veiculo(marca, modelo, ano, quilometragem);
            garagem.AdicionarVeiculo(veiculo);
            Console.WriteLine("\nVeículo adicionado com sucesso!");
        }

        static void ListarVeiculos(Garagem garagem)
        {
            Console.Clear();
            Console.WriteLine("==============================================");
            Console.WriteLine("======   LISTA DE VEÍCULOS DISPONÍVEIS   =====");
            Console.WriteLine("==============================================");
            var veiculos = garagem.ListarTodosVeiculos(); // Obtém todos os veículos da garagem

            if (veiculos.Count == 0)
            {
                Console.WriteLine("\nNenhum veículo disponível.");
            }
            else
            {
                foreach (var veiculo in veiculos) // Itera sobre a lista de veículos
                {
                    veiculo.ExibirDetalhes(); // Exibe os detalhes de cada veículo
                }
            }
        }

        static void ComprarVeiculo(Garagem garagem, Cliente cliente)
        {
            Console.Clear();
            Console.WriteLine("==============================================");
            Console.WriteLine("=========   COMPRA DE VEÍCULO   =============");
            Console.WriteLine("==============================================");
            Console.Write("Digite o modelo do veículo a ser comprado: ");
            string modelo = Console.ReadLine();
            Veiculo veiculo = garagem.BuscarVeiculoPorModelo(modelo);
            if (veiculo != null)
            {
                cliente.ComprarVeiculo(veiculo, garagem);
                Console.WriteLine("\nVeículo comprado com sucesso!");
            }
            else
            {
                Console.WriteLine("\nVeículo não encontrado.");
            }
        }

        static void VenderVeiculo(Garagem garagem)
        {
            Console.Clear();
            Console.WriteLine("==============================================");
            Console.WriteLine("==========   VENDA DE VEÍCULO   =============");
            Console.WriteLine("==============================================");
            Console.Write("Digite o modelo do veículo a ser vendido: ");
            string modelo = Console.ReadLine();
            Veiculo veiculo = garagem.BuscarVeiculoPorModelo(modelo);
            if (veiculo != null)
            {
                garagem.VenderVeiculo(veiculo);
                Console.WriteLine("\nVeículo vendido com sucesso!");
            }
            else
            {
                Console.WriteLine("\nVeículo não encontrado.");
            }
        }
    }
}
 */

/*
 * /// Instância de Cachorro
Cachorro cachorro = new Cachorro("Rex");
cachorro.ExibirInformacoes();
cachorro.FazerSom();
cachorro.ExplicarHeranca();

// Instância de Gato
Gato gato = new Gato("Mimi");
gato.ExibirInformacoes();
gato.FazerSom();
gato.ExplicarHeranca();
 */

/*
 * // Criando um objeto Endereco que pode existir independentemente
Endereco endereco = new Endereco("Rua Principal", "Cidade Exemplo");

// Criando um objeto Pessoa que contém um Endereco (agregação)
PessoaAgrecacao pessoa = new PessoaAgrecacao("João", endereco);

// Exibir as informações da pessoa e seu endereço
pessoa.ExibirInformacoes();

// Explicando o conceito de agregação
pessoa.ExplicarAgregacao();

 */

/*
 * 
// Criando um objeto Departamento
Departamento departamento = new Departamento("Recursos Humanos");

// Criando um objeto Funcionario que está associado a um Departamento
Funcionario funcionarioComDepartamento = new Funcionario("Ana", departamento);

// Criando um objeto Funcionario sem associação a nenhum Departamento
Funcionario funcionarioSemDepartamento = new Funcionario("Carlos");

// Exibir as informações dos funcionários
funcionarioComDepartamento.ExibirInformacoes();
funcionarioSemDepartamento.ExibirInformacoes();

// Explicando o conceito de associação
funcionarioComDepartamento.ExplicarAssociacao();
 */

/*
 * // Criando um objeto Carro, que inclui a criação de um Motor
Carro carro = new Carro("Fusca", "Motor 1600");

// Exibindo informações sobre o carro e seu motor
carro.ExibirInformacoes();

// Explicando o conceito de composição
carro.ExplicarComposicao();

 */

/*
 * // Criando funcionários
FuncionarioMulti funcionario1 = new FuncionarioMulti("Ana");
FuncionarioMulti funcionario2 = new FuncionarioMulti("Carlos");

// Criando um projeto
Projeto projeto = new Projeto("Desenvolvimento de Software");

// Adicionando funcionários ao projeto
projeto.AdicionarFuncionario(funcionario1);
projeto.AdicionarFuncionario(funcionario2);

// Exibindo informações sobre o projeto e seus funcionários
projeto.ExibirInformacoes();

// Explicando o conceito de multiplicidade
projeto.ExplicarMultiplicidade();
 */

/*
 * AnimalAbs cachorro = new CachorroAbs("Rex");
AnimalAbs gato = new GatoAbs("Mimi");

// Exibindo informações e fazendo som dos animais
cachorro.ExibirInformacoes();
cachorro.FazerSom();

gato.ExibirInformacoes();
gato.FazerSom();

// Explicando o conceito de classe abstrata
cachorro.ExplicarClasseAbstrata();

 */

/*
 * // Criando instâncias de classes que implementam a interface
IAnimal cachorro = new CachorroInter("Rex");
IAnimal gato = new GatoInter("Mimi");

// Exibindo informações e sons dos animais
cachorro.ExibirInformacoes();
cachorro.FazerSom();

gato.ExibirInformacoes();
gato.FazerSom();

// Explicando o conceito de interface
ExplicadorDeInterface explicador = new ExplicadorDeInterface();
explicador.ExplicarInterface();

 */

/*
 * var exp = new ExplicadoraDePolimorfismo();
AnimalPoli[] animais = new AnimalPoli[3];
animais[0] = new CachorroPoli("Rex");
animais[1] = new GatoPoli("Mimi");
animais[2] = new AnimalPoli("Dinossauro");

foreach (AnimalPoli animal in animais)
{
    animal.FazerSom(); // Comportamento polimórfico
}
exp.ExplicarPolimorfismo();
 */


namespace LojaPerfumaria
{
    class Program
    {
        static List<Cliente> clientes = new List<Cliente>();
        static List<Perfume> perfumes = new List<Perfume>();
        static List<Venda> vendas = new List<Venda>();

        static void Main(string[] args)
        {
            CarregarDados();

            int opcao = -1; // Inicializar com um valor diferente de 0 para entrar no loop

            do
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Cyan;

                Console.Clear();
                Console.WriteLine("=============================================================");
                Console.WriteLine("==============   GERENCIAMENTO DE PERFUMARIA   ==============");
                Console.WriteLine("=============================================================");
                Console.WriteLine($"=                   Autor: Lia Costa                        =");
                Console.WriteLine($"=              Data e Hora: {DateTime.Now}             =");
                Console.WriteLine("=============================================================\n");

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("1. Gerenciar Perfumes");
                Console.WriteLine("2. Gerenciar Clientes");
                Console.WriteLine("3. Gerenciar Vendas");
                Console.WriteLine("4. Relatório Unificado");
                Console.WriteLine("0. Sair");

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("Escolha uma opção: ");
                string input = Console.ReadLine();

                // Tentar converter a entrada em um número
                if (int.TryParse(input, out opcao))
                {
                    switch (opcao)
                    {
                        case 1:
                            MenuPerfumes();
                            break;
                        case 2:
                            MenuClientes();
                            break;
                        case 3:
                            MenuVendas();
                            break;
                        case 4:
                            RelatorioUnificado();
                            break;
                        case 0:
                            SalvarDados(); // Salva dados antes de sair
                            Console.WriteLine("\nSaindo do programa...");
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nOpção inválida, tente novamente.");
                            break;
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nEntrada inválida. Por favor, insira um número.");
                }
                Console.ForegroundColor = ConsoleColor.Cyan;
            } while (opcao != 0);
        }

        static void MenuPerfumes()
        {
            int opcao = 0;
            do
            {
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Cyan;

                Console.WriteLine("=============================================================");
                Console.WriteLine("==============   GERENCIAMENTO DE PERFUMARIA   ==============");
                Console.WriteLine("=============================================================");
                Console.WriteLine($"=                   Autor: Lia Costa                        =");
                Console.WriteLine($"=              Data e Hora: {DateTime.Now}             =");
                Console.WriteLine("=============================================================\n");
                Console.WriteLine("=============================================================");
                Console.WriteLine("==================   GERENCIAR PERFUMES   ===================");
                Console.WriteLine("=============================================================");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("  +---------------------------------------+");
                Console.WriteLine("  |              OPÇÕES                   |");
                Console.WriteLine("  +---------------------------------------+");
                Console.WriteLine("  |  1. Adicionar Perfume                 |");
                Console.WriteLine("  |  2. Listar Perfumes                   |");
                Console.WriteLine("  |  3. Remover Perfume                   |");
                Console.WriteLine("  |  4. Alterar Perfume                   |");
                Console.WriteLine("  |  0. Voltar                            |");
                Console.WriteLine("  +---------------------------------------+");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("Escolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        AdicionarPerfume();
                        break;
                    case 2:
                        ListarPerfumes();
                        break;
                    case 3:
                        RemoverPerfume();
                        break;
                    case 4:
                        AlterarPerfume();
                        break;
                    case 0:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\nVoltando ao menu principal...");
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nOpção inválida, tente novamente.");
                        break;
                }
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey();
            } while (opcao != 0);
        }

        static void MenuClientes()
        {
            int opcao = 0;
            do
            {
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Cyan;

                Console.WriteLine("=============================================================");
                Console.WriteLine("==============   GERENCIAMENTO DE PERFUMARIA   ==============");
                Console.WriteLine("=============================================================");
                Console.WriteLine($"=                   Autor: Lia Costa                        =");
                Console.WriteLine($"=              Data e Hora: {DateTime.Now}             =");
                Console.WriteLine("=============================================================\n");
                Console.WriteLine("=============================================================");
                Console.WriteLine("==================   GERENCIAR CLIENTES   ===================");
                Console.WriteLine("=============================================================");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("  +---------------------------------------+");
                Console.WriteLine("  |              OPÇÕES                   |");
                Console.WriteLine("  +---------------------------------------+");
                Console.WriteLine("  |  1. Adicionar Cliente                 |");
                Console.WriteLine("  |  2. Listar Clientes                   |");
                Console.WriteLine("  |  3. Remover Cliente                   |");
                Console.WriteLine("  |  4. Alterar Cliente                   |");
                Console.WriteLine("  |  0. Voltar                            |");
                Console.WriteLine("  +---------------------------------------+");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("Escolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        AdicionarCliente();
                        break;
                    case 2:
                        ListarClientes();
                        break;
                    case 3:
                        RemoverCliente();
                        break;
                    case 4:
                        AlterarCliente();
                        break;
                    case 0:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\nVoltando ao menu principal...");
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nOpção inválida, tente novamente.");
                        break;
                }
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey();
            } while (opcao != 0);
        }

        static void MenuVendas()
        {
            int opcao = 0;
            do
            {
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Cyan;

                Console.WriteLine("=============================================================");
                Console.WriteLine("==============   GERENCIAMENTO DE PERFUMARIA   ==============");
                Console.WriteLine("=============================================================");
                Console.WriteLine($"=                   Autor: Lia Costa                        =");
                Console.WriteLine($"=              Data e Hora: {DateTime.Now}             =");
                Console.WriteLine("=============================================================\n");
                Console.WriteLine("=============================================================");
                Console.WriteLine("==================     GERENCIAR VENDAS    ==================");
                Console.WriteLine("=============================================================");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("  +---------------------------------------+");
                Console.WriteLine("  |              OPÇÕES                   |");
                Console.WriteLine("  +---------------------------------------+");
                Console.WriteLine("  |  1. Adicionar Venda                   |");
                Console.WriteLine("  |  2. Listar Vendas                     |");
                Console.WriteLine("  |  3. Alterar Venda                     |");
                Console.WriteLine("  |  4. Remover Venda                     |");
                Console.WriteLine("  |  0. Voltar                            |");
                Console.WriteLine("  +---------------------------------------+");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("Escolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        AdicionarVenda();
                        break;
                    case 2:
                        ListarVendas();
                        break;
                    case 3:
                        AlterarVenda();
                        break;
                    case 4:
                        RemoverVenda();
                        break;
                    case 0:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\nVoltando ao menu principal...");
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nOpção inválida, tente novamente.");
                        break;
                }
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey();
            } while (opcao != 0);
        }

        static void RelatorioUnificado()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("=============================================================");
            Console.WriteLine("===============  RELATÓRIO UNIFICADO DE DADOS  ==============");
            Console.WriteLine("=============================================================\n");

            if (vendas.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Não há vendas registradas.");
            }
            else
            {
                foreach (var venda in vendas)
                {
                    // Encontrar o cliente e o perfume correspondente à venda
                    Cliente cliente = clientes.FirstOrDefault(c => c.Cpf == venda.ClienteCpf);
                    Perfume perfume = perfumes.FirstOrDefault(p => p.Nome == venda.PerfumeNome);

                    if (cliente != null && perfume != null)
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine($"Venda nº {vendas.IndexOf(venda) + 1}");
                        Console.WriteLine($"Cliente: {cliente.Nome} (CPF: {cliente.Cpf})");
                        Console.WriteLine($"Perfume: {perfume.Nome} (Marca: {perfume.Marca})");
                        Console.WriteLine($"Data da Venda: {venda.DataVenda}");
                        Console.WriteLine($"Preço: {venda.Preco:C}");
                        Console.WriteLine("-------------------------------------------------------------");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine($"Venda nº {vendas.IndexOf(venda) + 1}");
                        Console.WriteLine("Informações do cliente ou perfume não encontradas.");
                        Console.WriteLine("-------------------------------------------------------------");
                    }
                }
            }

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
        }

        static void AdicionarPerfume()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("=============================================================");
            Console.WriteLine("==============   GERENCIAMENTO DE PERFUMARIA   ==============");
            Console.WriteLine("=============================================================");
            Console.WriteLine($"=                   Autor: Lia Costa                        =");
            Console.WriteLine($"=              Data e Hora: {DateTime.Now}             =");
            Console.WriteLine("=============================================================\n");
            Console.WriteLine("==============================================");
            Console.WriteLine("=========   ADICIONAR NOVO PERFUME   =========");
            Console.WriteLine("==============================================");

            string nome, marca;
            decimal preco;

            // Validação do Nome
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("Digite o nome do perfume: ");
                nome = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(nome) || !System.Text.RegularExpressions.Regex.IsMatch(nome, @"^[a-zA-Z\s]+$"))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Nome inválido. Apenas letras e espaços são permitidos.");
                    Console.ResetColor();
                    continue;
                }
                break;
            }

            // Validação da Marca
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("Digite a marca do perfume: ");
                marca = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(marca) || !System.Text.RegularExpressions.Regex.IsMatch(marca, @"^[a-zA-Z\s]+$"))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Marca inválida. Apenas letras e espaços são permitidos.");
                    Console.ResetColor();
                    continue;
                }
                break;
            }

            // Validação do Preço
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("Digite o preço do perfume: ");
                if (!decimal.TryParse(Console.ReadLine(), out preco) || preco <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Preço inválido. Deve ser um valor numérico positivo.");
                    Console.ResetColor();
                    continue;
                }
                break;
            }

            Perfume perfume = new Perfume(nome, marca, preco);
            perfumes.Add(perfume);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nPerfume adicionado com sucesso!");
            SalvarPerfumes(); // Atualiza o arquivo após adicionar perfume

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
        }

        static void AdicionarCliente()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("=============================================================");
            Console.WriteLine("==============   GERENCIAMENTO DE PERFUMARIA   ==============");
            Console.WriteLine("=============================================================");
            Console.WriteLine($"=                   Autor: Lia Costa                        =");
            Console.WriteLine($"=              Data e Hora: {DateTime.Now}             =");
            Console.WriteLine("=============================================================\n");
            Console.WriteLine("=============================================================");
            Console.WriteLine("==========         ADICIONAR NOVO CLIENTE          ==========");
            Console.WriteLine("=============================================================");

            string nome, cpf;

            // Validação do Nome
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("Digite o nome do cliente: ");
                nome = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(nome) || !System.Text.RegularExpressions.Regex.IsMatch(nome, @"^[a-zA-Z\s]+$"))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Nome inválido. Apenas letras e espaços são permitidos.");
                    Console.ResetColor();
                    continue;
                }
                break;
            }

            // Validação do CPF
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("Digite o CPF do cliente (apenas números): ");
                cpf = Console.ReadLine();

                if (cpf.Length != 11 || !cpf.All(char.IsDigit))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("CPF inválido. Deve ter exatamente 11 números.");
                    Console.ResetColor();
                    continue;
                }

                // Verificar se o CPF já existe
                if (clientes.Any(c => c.Cpf == cpf))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nCliente com este CPF já existe.");
                    return;
                }
                break;
            }

            Cliente cliente = new Cliente(nome, cpf);
            clientes.Add(cliente);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nCliente adicionado com sucesso!");
            SalvarClientes(); // Atualiza o arquivo após adicionar cliente

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
        }

        static void AdicionarVenda()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("=============================================================");
            Console.WriteLine("==============   GERENCIAMENTO DE PERFUMARIA   ==============");
            Console.WriteLine("=============================================================");
            Console.WriteLine($"=                   Autor: Lia Costa                        =");
            Console.WriteLine($"=              Data e Hora: {DateTime.Now}             =");
            Console.WriteLine("=============================================================\n");
            Console.WriteLine("=============================================================");
            Console.WriteLine("==========         ADICIONAR NOVA VENDA          ==========");
            Console.WriteLine("=============================================================");

            ListarClientes();
            int clienteIndice;

            // Validação do número do cliente
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("\nDigite o número do cliente que fez a compra: ");
                if (int.TryParse(Console.ReadLine(), out clienteIndice) && clienteIndice > 0 && clienteIndice <= clientes.Count)
                {
                    clienteIndice--; // Ajustar para índice de lista
                    break;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Número do cliente inválido. Tente novamente.");
                    Console.ResetColor();
                }
            }

            Cliente cliente = clientes[clienteIndice];

            ListarPerfumes();
            int perfumeIndice;

            // Validação do número do perfume
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("\nDigite o número do perfume vendido: ");
                if (int.TryParse(Console.ReadLine(), out perfumeIndice) && perfumeIndice > 0 && perfumeIndice <= perfumes.Count)
                {
                    perfumeIndice--; // Ajustar para índice de lista
                    break;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Número do perfume inválido. Tente novamente.");
                    Console.ResetColor();
                }
            }

            Perfume perfume = perfumes[perfumeIndice];

            string dataVenda;

            // Validação da data de venda
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("Digite a data da venda (YYYY-MM-DD): ");
                dataVenda = Console.ReadLine();

                if (DateTime.TryParse(dataVenda, out _))
                {
                    break;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Data inválida. Insira no formato correto (YYYY-MM-DD).");
                    Console.ResetColor();
                }
            }

            decimal preco = perfume.Preco;

            // Registro da venda
            Venda venda = new Venda(cliente.Cpf, perfume.Nome, dataVenda, preco);
            vendas.Add(venda);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nVenda registrada com sucesso!");
            SalvarVendas(); // Atualiza o arquivo após adicionar venda

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
        }

        static void RemoverPerfume()
        {
            ListarPerfumes();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("\nDigite o número do perfume a ser removido: ");
            int indice = int.Parse(Console.ReadLine()) - 1;

            if (indice >= 0 && indice < perfumes.Count)
            {
                Console.Write("Você tem certeza que deseja remover este perfume? (S/N): ");
                string resposta = Console.ReadLine();

                if (resposta.ToLower() == "s")
                {
                    perfumes.RemoveAt(indice);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nPerfume removido com sucesso!");
                    SalvarPerfumes(); // Atualiza o arquivo após remoção
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\nOperação cancelada.");
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nNúmero inválido.");
            }

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
        }

        static void RemoverCliente()
        {
            ListarClientes();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("\nDigite o número do cliente a ser removido: ");
            int indice = int.Parse(Console.ReadLine()) - 1;

            if (indice >= 0 && indice < clientes.Count)
            {
                Console.Write("Você tem certeza que deseja remover este cliente? (S/N): ");
                string resposta = Console.ReadLine();

                if (resposta.ToLower() == "s")
                {
                    clientes.RemoveAt(indice);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nCliente removido com sucesso!");
                    SalvarClientes(); // Atualiza o arquivo após remoção
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\nOperação cancelada.");
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nNúmero inválido.");
            }

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
        }

        static void RemoverVenda()
        {
            ListarVendas();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("\nDigite o número da venda a ser removida: ");
            int indice = int.Parse(Console.ReadLine()) - 1;

            if (indice >= 0 && indice < clientes.Count)
            {
                Console.Write("Você tem certeza que deseja remover esta venda? (S/N): ");
                string resposta = Console.ReadLine();

                if (resposta.ToLower() == "s")
                {
                    clientes.RemoveAt(indice);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nVenda removida com sucesso!");
                    SalvarClientes(); // Atualiza o arquivo após remoção
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\nOperação cancelada.");
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nNúmero inválido.");
            }

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
        }

        static void AlterarPerfume()
        {
            ListarPerfumes();
            int indice;

            // Validação do número do perfume
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("\nDigite o número do perfume a ser alterado: ");
                if (int.TryParse(Console.ReadLine(), out indice) && indice > 0 && indice <= perfumes.Count)
                {
                    indice--; // Ajustar para índice de lista
                    break;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Número do perfume inválido. Tente novamente.");
                    Console.ResetColor();
                }
            }

            Perfume perfume = perfumes[indice];

            string novoNome, novaMarca;
            decimal novoPreco;

            // Validação do Nome do Perfume
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("Digite o novo nome do perfume: ");
                novoNome = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(novoNome) || !System.Text.RegularExpressions.Regex.IsMatch(novoNome, @"^[a-zA-Z\s]+$"))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Nome do perfume inválido. Apenas letras e espaços são permitidos.");
                    Console.ResetColor();
                    continue;
                }
                break;
            }

            // Validação da Marca do Perfume
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("Digite a nova marca do perfume: ");
                novaMarca = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(novaMarca) || !System.Text.RegularExpressions.Regex.IsMatch(novaMarca, @"^[a-zA-Z\s]+$"))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Marca do perfume inválida. Apenas letras e espaços são permitidos.");
                    Console.ResetColor();
                    continue;
                }
                break;
            }

            // Validação do Preço do Perfume
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("Digite o novo preço do perfume: ");
                if (decimal.TryParse(Console.ReadLine(), out novoPreco) && novoPreco > 0)
                {
                    break;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Preço inválido. Deve ser um número positivo.");
                    Console.ResetColor();
                }
            }

            // Alterar os dados do perfume
            perfume.Nome = novoNome;
            perfume.Marca = novaMarca;
            perfume.Preco = novoPreco;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nPerfume alterado com sucesso!");
            SalvarPerfumes(); // Atualiza o arquivo após alterar perfume

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
        }

        static void AlterarCliente()
        {
            ListarClientes();
            int indice;

            // Validação do número do cliente
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("\nDigite o número do cliente a ser alterado: ");
                if (int.TryParse(Console.ReadLine(), out indice) && indice > 0 && indice <= clientes.Count)
                {
                    indice--; // Ajusta para índice da lista
                    break;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Número do cliente inválido. Tente novamente.");
                    Console.ResetColor();
                }
            }

            Cliente cliente = clientes[indice];

            string novoNome, novoCpf;

            // Validação do Nome do Cliente
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("Digite o novo nome do cliente: ");
                novoNome = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(novoNome) || !System.Text.RegularExpressions.Regex.IsMatch(novoNome, @"^[a-zA-Z\s]+$"))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Nome do cliente inválido. Apenas letras e espaços são permitidos.");
                    Console.ResetColor();
                    continue;
                }
                break;
            }

            // Validação do CPF do Cliente
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("Digite o novo CPF do cliente (apenas números): ");
                novoCpf = Console.ReadLine();

                if (novoCpf.Length != 11 || !novoCpf.All(char.IsDigit))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("CPF inválido. Deve ter exatamente 11 números.");
                    Console.ResetColor();
                    continue;
                }

                // Verificar se o CPF já existe
                if (clientes.Any(c => c.Cpf == novoCpf && c != cliente))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("CPF já cadastrado para outro cliente. Tente um CPF diferente.");
                    Console.ResetColor();
                    continue;
                }
                break;
            }

            // Atualizar os dados do cliente
            cliente.Nome = novoNome;
            cliente.Cpf = novoCpf;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nCliente alterado com sucesso!");
            SalvarClientes(); // Atualiza o arquivo após alterar cliente

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
        }

        static void AlterarVenda()
        {
            ListarVendas();
            int indice;

            // Validação do número da venda
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("\nDigite o número da venda a ser alterada: ");
                if (int.TryParse(Console.ReadLine(), out indice) && indice > 0 && indice <= vendas.Count)
                {
                    indice--; // Ajusta para índice da lista
                    break;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Número da venda inválido. Tente novamente.");
                    Console.ResetColor();
                }
            }

            Venda venda = vendas[indice];
            string novoCpf, novoNomePerfume, novaDataVenda;
            decimal novoPreco;

            // Validação do CPF do Cliente
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("Digite o novo CPF do cliente (apenas números): ");
                novoCpf = Console.ReadLine();

                if (novoCpf.Length != 11 || !novoCpf.All(char.IsDigit))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("CPF inválido. Deve ter exatamente 11 números.");
                    Console.ResetColor();
                    continue;
                }

                // Verificar se o CPF existe
                if (!clientes.Any(c => c.Cpf == novoCpf))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("CPF não encontrado. Certifique-se de que o cliente está cadastrado.");
                    Console.ResetColor();
                    continue;
                }

                break;
            }

            // Validação do nome do perfume
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("Digite o novo nome do perfume: ");
                novoNomePerfume = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(novoNomePerfume))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Nome do perfume não pode ser vazio.");
                    Console.ResetColor();
                    continue;
                }

                // Verificar se o perfume existe
                if (!perfumes.Any(p => p.Nome == novoNomePerfume))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Perfume não encontrado. Verifique o nome corretamente.");
                    Console.ResetColor();
                    continue;
                }

                break;
            }

            // Validação da data da venda
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("Digite a nova data da venda (YYYY-MM-DD): ");
                novaDataVenda = Console.ReadLine();

                if (!DateTime.TryParse(novaDataVenda, out DateTime dataVendaValida))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Data inválida. Formato correto: YYYY-MM-DD.");
                    Console.ResetColor();
                    continue;
                }

                break;
            }

            // Validação do preço da venda
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("Digite o novo preço da venda: ");
                if (decimal.TryParse(Console.ReadLine(), out novoPreco) && novoPreco >= 0)
                {
                    break;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Preço inválido. Insira um valor numérico positivo.");
                    Console.ResetColor();
                }
            }

            // Atualizar os dados da venda
            venda.ClienteCpf = novoCpf;
            venda.PerfumeNome = novoNomePerfume;
            venda.DataVenda = novaDataVenda;
            venda.Preco = novoPreco;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nVenda alterada com sucesso!");
            SalvarVendas(); // Atualiza o arquivo após alterar venda

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
        }

        static void ListarPerfumes()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("=======================================================================");
            Console.WriteLine("==================    GERENCIAMENTO DE PERFUMARIA    ==================");
            Console.WriteLine("=======================================================================");
            Console.WriteLine($"=                         Autor: Lia Costa                            =");
            Console.WriteLine($"=                  Data e Hora: {DateTime.Now}                   =");
            Console.WriteLine("=======================================================================\n");
            Console.WriteLine("╔═════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║                          LISTA DE PERFUMES                          ║");
            Console.WriteLine("╚═════════════════════════════════════════════════════════════════════╝");

            Console.ForegroundColor = ConsoleColor.White; // Verde Neon
            Console.WriteLine($"║  Data e Hora: {DateTime.Now:dd/MM/yyyy HH:mm}                                      ║");

            Console.ForegroundColor = ConsoleColor.Cyan; // Ciano
            Console.WriteLine("╚═════════════════════════════════════════════════════════════════════╝");

            Console.ForegroundColor = ConsoleColor.White; // Branco para texto normal

            if (perfumes.Count == 0)
            {
                Console.WriteLine("\nNenhum perfume cadastrado.");
            }
            else
            {
                // Cabeçalhos da tabela
                Console.ForegroundColor = ConsoleColor.Magenta; // Pink
                Console.WriteLine("╔═════╦═══════════════════════════════════════════════════╦═══════════════════════════╦══════════════╗");
                Console.WriteLine("║ ID  ║ Nome                                              ║ Marca                     ║ Preço        ║");
                Console.WriteLine("╠═════╬═══════════════════════════════════════════════════╬═══════════════════════════╬══════════════╣");

                // Dados dos perfumes
                Console.ForegroundColor = ConsoleColor.White; // Branco para os dados
                foreach (var perfume in perfumes)
                {
                    Console.WriteLine($"║ {perfumes.IndexOf(perfume) + 1,-3} ║ {perfume.Nome,-50}║ {perfume.Marca,-24}  ║ R$ {perfume.Preco,-10:F2}║");
                }

                // Linha de rodapé
                Console.ForegroundColor = ConsoleColor.Magenta; // Pink
                Console.WriteLine("╚═════╩═══════════════════════════════════════════════════╩═══════════════════════════╩══════════════╝");
            }

            Console.ForegroundColor = ConsoleColor.Cyan; // Ciano
            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
        }

        static void ListarClientes()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("=======================================================================");
            Console.WriteLine("==================    GERENCIAMENTO DE PERFUMARIA    ==================");
            Console.WriteLine("=======================================================================");
            Console.WriteLine($"=                         Autor: Lia Costa                            =");
            Console.WriteLine($"=                  Data e Hora: {DateTime.Now}                   =");
            Console.WriteLine("=======================================================================\n");
            Console.WriteLine("╔═════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║                          LISTA DE CLIENTES                          ║");
            Console.WriteLine("╚═════════════════════════════════════════════════════════════════════╝");

            Console.ForegroundColor = ConsoleColor.White; // Verde Neon
            Console.WriteLine($"║  Data e Hora: {DateTime.Now:dd/MM/yyyy HH:mm}                                      ║");

            Console.ForegroundColor = ConsoleColor.Cyan; // Ciano
            Console.WriteLine("╚═════════════════════════════════════════════════════════════════════╝");

            Console.ForegroundColor = ConsoleColor.White; // Branco para texto normal

            if (clientes.Count == 0)
            {
                Console.WriteLine("\nNenhum cliente cadastrado.");
            }
            else
            {
                // Cabeçalhos da tabela
                Console.ForegroundColor = ConsoleColor.Magenta; // Pink
                Console.WriteLine("╔═════╦══════════════════════════════════════╦══════════════════╗");
                Console.WriteLine("║ ID  ║ Nome                                 ║ CPF              ║");
                Console.WriteLine("╠═════╬══════════════════════════════════════╬══════════════════╣");

                // Dados dos clientes
                Console.ForegroundColor = ConsoleColor.White; // Branco para os dados
                for (int i = 0; i < clientes.Count; i++)
                {
                    Console.WriteLine($"║ {i + 1,-3} ║ {clientes[i].Nome,-36} ║ {clientes[i].Cpf,-0}   ║");
                }

                // Linha de rodapé
                Console.ForegroundColor = ConsoleColor.Magenta; // Pink
                Console.WriteLine("╚═════╩══════════════════════════════════════╩══════════════════╝");
            }

            Console.ForegroundColor = ConsoleColor.Cyan; // Ciano
            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
        }

        static void ListarVendas()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("=======================================================================");
            Console.WriteLine("==================    GERENCIAMENTO DE PERFUMARIA    ==================");
            Console.WriteLine("=======================================================================");
            Console.WriteLine($"=                         Autor: Lia Costa                            =");
            Console.WriteLine($"=                  Data e Hora: {DateTime.Now}                   =");
            Console.WriteLine("=======================================================================\n");
            Console.WriteLine("╔═════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║                          LISTA DE VENDAS                            ║");
            Console.WriteLine("╚═════════════════════════════════════════════════════════════════════╝");

            Console.ForegroundColor = ConsoleColor.White; // Verde Neon
            Console.WriteLine($"║  Data e Hora: {DateTime.Now:dd/MM/yyyy HH:mm}                                      ║");

            Console.ForegroundColor = ConsoleColor.Cyan; // Ciano
            Console.WriteLine("╚═════════════════════════════════════════════════════════════════════╝");

            Console.ForegroundColor = ConsoleColor.White; // Branco para texto normal

            if (vendas.Count == 0)
            {
                Console.WriteLine("\nNenhuma venda cadastrada.");
            }
            else
            {
                // Cabeçalhos da tabela
                Console.ForegroundColor = ConsoleColor.Magenta; // Pink
                Console.WriteLine("╔═════╦══════════════════════╦══════════════════════╦════════════╦════════════╗");
                Console.WriteLine("║ ID  ║ CPF do Cliente       ║ Nome do Perfume      ║ Data Venda ║ Preço      ║");
                Console.WriteLine("╠═════╬══════════════════════╬══════════════════════╬════════════╬════════════╣");

                // Dados das vendas
                Console.ForegroundColor = ConsoleColor.White; // Branco para os dados
                for (int i = 0; i < vendas.Count; i++)
                {
                    Console.WriteLine($"║ {i + 1,-3} ║ {vendas[i].ClienteCpf,-20} ║ {vendas[i].PerfumeNome,-20} ║ {vendas[i].DataVenda,-9} ║ R$ {vendas[i].Preco,-7:F2}║");
                }

                // Linha de rodapé
                Console.ForegroundColor = ConsoleColor.Magenta; // Pink
                Console.WriteLine("╚═════╩══════════════════════╩══════════════════════╩════════════╩════════════╝");
            }

            Console.ForegroundColor = ConsoleColor.Cyan; // Ciano
            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
        }        

        static void CarregarDados()
        {
            if (File.Exists("perfumes.json"))
            {
                string json = File.ReadAllText("perfumes.json");
                perfumes = JsonSerializer.Deserialize<List<Perfume>>(json);
            }

            if (File.Exists("clientes.json"))
            {
                string json = File.ReadAllText("clientes.json");
                clientes = JsonSerializer.Deserialize<List<Cliente>>(json);
            }

            if (File.Exists("vendas.json"))
            {
                string json = File.ReadAllText("vendas.json");
                vendas = JsonSerializer.Deserialize<List<Venda>>(json);
            }
        }

        static void SalvarDados()
        {
            SalvarPerfumes();
            SalvarClientes();
            SalvarVendas();
        }

        static void SalvarPerfumes()
        {
            string json = JsonSerializer.Serialize(perfumes);
            File.WriteAllText("perfumes.json", json);
        }

        static void SalvarClientes()
        {
            string json = JsonSerializer.Serialize(clientes);
            File.WriteAllText("clientes.json", json);
        }

        static void SalvarVendas()
        {
            string json = JsonSerializer.Serialize(vendas);
            File.WriteAllText("vendas.json", json);
        }
    }

    public class Perfume
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

    public class Cliente
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }

        public Cliente(string nome, string cpf)
        {
            Nome = nome;
            Cpf = cpf;
        }
    }

    public class Venda
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




