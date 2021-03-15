using System;
/* FATEC CRUZEIRO - ATIVIDADE DE POO - MARCH/2021
2 ) Desenvolvam em grupo, em C# uma calculadora que execute as 4 operações básicas de dois valores
inseridos pelo usuário: adição, subtração, multiplicação divisão.
Lembre-se de:
- solicitar que o usuário insira os dois números (ou mais);
- cada operação deverá estar codificada como uma função;
- utilize as boas práticas / padronização que definiu com seus colegas para fazer comentários e para
nomear variáveis, e assim facilitar que outros programadores possam analisar seu código. 

-------------------------------------------------------------
OBS.: ACHO QUE É SÓ DIVIDIR CADA "CASE" EM UMA FUNÇÃO
-------------------------------------------------------------

 */

namespace CalculatorTabajaras
{
		class Varian
		{
			static double a, b, r, opcao;

			static void Main(string[] args)
			{

				Console.Write("Entre com um numero =  ");
				a = Convert.ToDouble(Console.ReadLine());
				Console.WriteLine();
				Console.Write("Entre com outro numero =  ");
				b = Convert.ToDouble(Console.ReadLine());
				Console.Write("Escolha a operação matemática \n");
				Console.Write("1 - Soma \n");
				Console.Write("2 - Subtrair \n");
				Console.Write("3 - Dividir \n");
				Console.Write("4 - Multiplicar \n");
				Console.Write("--->>>  ");
				opcao = Convert.ToDouble(Console.ReadLine());

				switch (opcao)
				{
					case 1: // 1 - suma
						r = a + b;
						Console.Write($"Resultado = {r}");
						break;
					case 2: // 1 - Subraiur
						r = a - b;
						Console.Write("Resultado = " + r);
						break;
					case 3: // 1 - Divudir
						r = a / b;
						Console.Write("Resultado = {0:G}", r);
						break;
					case 4: // 1 - Murtirpricar
						r = a * b;
						Console.Write("Resultado = {0:G} \n", r); // todas as casas possíveis

						break;
					default:
						break;
					//Teste para ver se houve alteração
					//Testando outra alteração no programa
				}

			}
			static string Second(int result)
			{
				return "algumacoisa " + result;
			}
		}

}
