using System;
using System.Collections.Generic;
using System.Text;

namespace SalarioFuncionario
{
    class Funcionario
    {
        private int matricula, horasTrabalhadas;
        private double valorSalario, salarioFinal;

		public int Matricula { get => matricula; set => matricula = value; }
		public int HorasTrabalhadas { get => horasTrabalhadas; set => horasTrabalhadas = value; }
		public double ValorSalario { get => valorSalario; set => valorSalario = value; }
		public double SalarioFinal { get => salarioFinal; set => salarioFinal = value; }

		public void CalculaSalarioFinal() 
		{
			SalarioFinal = ValorSalario * HorasTrabalhadas;
		}
	}
}
