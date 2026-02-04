using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaGerenciamentoFuncionario
{
    internal class Empresa
    {
        private string nomeEmpresa;
        private List<Departamento> departamentos = new List<Departamento>();

        public Empresa(string nomeEmpresa)
        {
            this.nomeEmpresa = nomeEmpresa;
        }
        public int NumeroDeDepartamentos { get { return departamentos.Count; } }
        public void AdicionarDepartamentos(Departamento departamento)
        {
            departamentos.Add(departamento);
        }
        public void MostrarDepartamentos()
        {
            if (NumeroDeDepartamentos != 0)
            {
                foreach (Departamento departamento in departamentos)
                {
                    Console.WriteLine("Departamento: " + departamento.NomeDeDepartamento);
                    Console.WriteLine("Quantidade de funcionários do departamento: " + departamento.NumerosDeFuncionarios);
                }
            }
            else
            {
                Console.WriteLine("Não há departamentos existentes.");
            }

        }
        public void BuscarFuncionarioPorCodigo(string cod)
        {
            bool achei = false;

            foreach (Departamento departamento in departamentos)
            {
                if (departamento.BuscarFuncionario(cod))
                {
                    achei = true;
                }
            }
            if (!achei)
            {
                Console.WriteLine("Funcionário não encontrado.");
            }
        }
    }
}
