/*Exercícios de fixação –entregar: 29-03-2021
1 ) Fazer um programa que leia o número de matrícula de um funcionário, quantidade de horas trabalhadas no
mês, o valor que recebe por hora e calcule o salário desse funcionário. A seguir, mostre o número de matrícula
e o salário total do funcionário (com duas casas decimais). {base para pensar em algo mais elaborado, que
pode ser desenhado como parte de um sistema para implantar para uma pequena empresa gerar relatórios
mensais para o contador}
*/

using System;

namespace SalarioFuncionario
{
	class SalFunc
	{
		static void Main(string[] args)
		{
			bool continua = false;

			Funcionario funcionario;

			while (!continua) {
				funcionario = new Funcionario();

				try
				{
					Console.WriteLine("Digitar matrícula: ");
					funcionario.Matricula = Convert.ToInt32(Console.ReadLine());
					Console.WriteLine("Digitar quantidade de horas trabalhadas: ");
					funcionario.HorasTrabalhadas = Convert.ToInt32(Console.ReadLine());
					Console.WriteLine("Digitar valor do sálario por hora(utilize vírgula para separar as casas decimais): ");
					funcionario.ValorSalario = Convert.ToDouble(Console.ReadLine());

					funcionario.CalculaSalarioFinal();

					Console.WriteLine($"\nO funcionário da matrícula {funcionario.Matricula} recebeu um total " +
									  $"de R$ {funcionario.SalarioFinal} por {funcionario.HorasTrabalhadas}H\n");
				}
				catch (Exception ex) 
				{
					Console.WriteLine("\nAlgum dado não foi digitado corretamente \n");
				}

				Console.WriteLine("Deseja consultar de outro funcionário (Y - sim, N - não): ");
				continua = Console.ReadLine().Equals("Y", StringComparison.OrdinalIgnoreCase) ? false : true;
			}
		}
	}
}
