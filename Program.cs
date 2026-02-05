namespace SistemaGerenciamentoFuncionario
{
    internal class Program
    {

        static void Main(string[] args)
        {

            Empresa empresa = null;
            Departamento departamento = null;
            Funcionario funcionario = null;

            string nomeEmpresa;
            string nomeDepto;
            string codigo;
            string nome;
            string cargo;
            string codBusca;
            string buscaDepto;

            double salarioBase;
            int opcao;
            bool sair = true;


            Console.Write("Informe o nome da empresa: ");
            nomeEmpresa = Console.ReadLine();
            empresa = new Empresa(nomeEmpresa);



            do
            {
                Console.WriteLine("\n--- MENU DE GESTÃO ---");
                Console.WriteLine("1. Cadastrar Departamento");
                Console.WriteLine("2. Cadastrar Funcionário");
                Console.WriteLine("3. Listar Funcionários de um Departamento");
                Console.WriteLine("4. Listar Funcionários Bem Pagos");
                Console.WriteLine("5. Listar Departamentos");
                Console.WriteLine("6. Buscar Funcionário Por Código");
                Console.WriteLine("7. Sair");
                Console.Write("Escolha uma opção: ");

                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.Write("Informe o nome do departamento: ");
                        nomeDepto = Console.ReadLine();

                        departamento = new Departamento(nomeDepto);
                        empresa.AdicionarDepartamentos(departamento);
                        Console.WriteLine("Departamento cadastrado!");
                        break;

                    case 2:
                        if (empresa.NumeroDeDepartamentos == 0)
                        {
                            Console.WriteLine("Erro: Cadastre ao menos um departamento antes!");
                            break;
                        }

                        Console.Write("Informe o departamento no qual o funcionário irá trabalhar: ");
                        buscaDepto = Console.ReadLine();
                      
                        Departamento deptoEncontrado = empresa.ObterDepartamento(buscaDepto);

                        if (deptoEncontrado != null)
                        {
                            Console.WriteLine($"--- CADASTRANDO EM: {deptoEncontrado.NomeDeDepartamento} ---");
                            Console.Write("Código: ");
                            codigo = Console.ReadLine();
                            Console.Write("Nome: ");
                            nome = Console.ReadLine();
                            Console.Write("Salário Base: ");
                            salarioBase = double.Parse(Console.ReadLine());
                            Console.Write("Cargo: ");
                            cargo = Console.ReadLine();

                            funcionario = new Funcionario(codigo, nome, salarioBase, cargo);                         
                            deptoEncontrado.AdicionarFuncionarios(funcionario);

                            Console.WriteLine($"Sucesso! {nome} adicionado ao setor {deptoEncontrado.NomeDeDepartamento}.");
                        }
                        else
                        {
                            Console.WriteLine("Erro: Departamento não encontrado!");
                        }
                        break;

                    case 3:

                        Console.WriteLine("Informe o nome do departamento: ");
                        nomeDepto = Console.ReadLine();
                        empresa.ListarFuncionariosDeUmDepartamento(nomeDepto);
                        break;

                    case 4:
                        if (departamento != null)
                        {
                            departamento.ListarFuncionariosBemPagos();
                        }
                        else
                        {
                            Console.WriteLine("Erro: Nenhum departamento foi cadastrado ainda!");
                        }
                        break;

                    case 5:                    
                        empresa.MostrarDepartamentos();
                        break;

                    case 6:
                        Console.Write("Informe o código parasim busca: ");
                        codBusca = Console.ReadLine();
                        departamento.BuscarFuncionario(codBusca);
                        break;

                    case 7:
                        Console.WriteLine("Saindo...");
                        sair = false;
                        break;

                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }

            } while (sair);
        }
    }
}
