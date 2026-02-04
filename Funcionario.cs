using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaGerenciamentoFuncionario
{
    internal class Funcionario
    {
        private string codigo;
        private string nome;
        private double salarioBase;
        private string cargo;

        public Funcionario(string codigo, string nome, double salarioBase, string cargo)
        {
            this.codigo = codigo;
            this.nome = nome;
            this.salarioBase = salarioBase;
            this.cargo = cargo;
        }
        public string Codigo { get { return codigo; } }
        public string Nome { get { return nome; } }
        public double SalarioBase { get { return salarioBase; } }
        public string Cargo { get { return cargo; } }
        public double CalcularSalario()
        {
            double salarioFinal;

            if (cargo.ToLower() == "gerente")
            {
                salarioFinal = salarioBase * 1.20;
                return salarioFinal;
            }
            else if (cargo.ToLower() == "analista")
            {
                salarioFinal = salarioBase * 1.10;
                return salarioFinal;
            }
            else
            {
                return salarioBase;
            }

        }
        public string Situacao
        {
            get
            {
                if (CalcularSalario() >= 5000)
                    return "Bem pago";
                if (CalcularSalario() >= 2000 && CalcularSalario() < 5000)
                    return "Regular";

                return "Baixo";
            }
        }
    }
}
