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
        public Departamento ProcurarDepartamento(string nomeDepto)
        { 
            foreach(Departamento departamento in departamentos)
            {
                if (nomeDepto == departamento.NomeDeDepartamento)
                {
                    return departamento;
                }
            }
            return null;
        }
        public Departamento ObterDepartamento(string nomeDepto)
        {
            foreach (Departamento departamento in departamentos)
            {
                if (departamento.NomeDeDepartamento == nomeDepto)
                {
                    return departamento;
                }
            }
            return null;
        }
        public void ListarFuncionariosDeUmDepartamento(string nomeDepto)
        {        
            bool acheiDepartamento = false;

            foreach (Departamento departamento in departamentos)
            {
                if (departamento.NomeDeDepartamento == nomeDepto)
                {
                    acheiDepartamento = true;
                    if (departamento.MostrarFuncionarios());
                }
            }
            if (!acheiDepartamento) { Console.WriteLine("Departamento não encontrado!"); }
               
        }
    }
}
