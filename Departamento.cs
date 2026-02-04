using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace SistemaGerenciamentoFuncionario
{
    internal class Departamento
    {
        private string nomeDepartamento;
        private List<Funcionario> funcionarios = new List<Funcionario>();

        public Departamento(string nomeDepartamento)
        {
            this.nomeDepartamento = nomeDepartamento;
        }
        public string NomeDeDepartamento { get { return  nomeDepartamento; }  }
        public int NumerosDeFuncionarios { get { return funcionarios.Count; }  }
        public void AdicionarFuncionarios(Funcionario funcionario)
        {
            funcionarios.Add(funcionario);
        }
        public void MostrarFuncionarios()
        {
            if (NumerosDeFuncionarios != 0)
            {
                foreach (Funcionario funcionario in funcionarios)
                {
                    Console.WriteLine("Código do Funcionário: " + funcionario.Codigo);
                    Console.WriteLine("Nome do Funcionário: " + funcionario.Nome);
                    Console.WriteLine("Salário Base do Funcionário: " + funcionario.SalarioBase);
                    Console.WriteLine("Cargo do Funcionário: " + funcionario.Cargo);
                }
            }
            else
            {
                Console.WriteLine("Não há funcionários cadastrados!");
            }
        }
        public void ListarFuncionariosBemPagos()
        {
            bool encontreiAlguem = false;

            foreach (Funcionario funcionario in funcionarios)
            {
                if (funcionario.CalcularSalario() >= 5000)
                {
                    Console.WriteLine("Código do Funcionário: " + funcionario.Codigo);
                    Console.WriteLine("Nome do Funcionário: " + funcionario.Nome);
                    Console.WriteLine("Salário Base do Funcionário: " + funcionario.SalarioBase);
                    Console.WriteLine("Cargo do Funcionário: " + funcionario.Cargo);
                    encontreiAlguem = true;
                }
            }
            if (!encontreiAlguem)
            {
                Console.WriteLine("Não há funcionários bem pagos.");
            }
        }
        public bool BuscarFuncionario(string codigo)
        {
            foreach (Funcionario funcionario in funcionarios)
            {
                if (codigo == funcionario.Codigo)
                {
                    Console.WriteLine("Código do Funcionário: " + funcionario.Codigo);
                    Console.WriteLine("Nome do Funcionário: " + funcionario.Nome);
                    Console.WriteLine("Salário Base do Funcionário: " + funcionario.SalarioBase);
                    Console.WriteLine("Cargo do Funcionário: " + funcionario.Cargo);
                    Console.WriteLine("Situação do Funcionário: " + funcionario.Situacao);

                    return true;
                    break;
                }
            }
            return false;
        }
    }
}
