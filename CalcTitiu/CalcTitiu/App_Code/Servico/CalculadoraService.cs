using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CalcTitiu.App_Code.Model;

namespace CalcTitiu.App_Code.Servico
{

    public class CalculadoraService
    {
        public int Somar(Calculadora calc)
        {
            calc.Resultado = calc.Nr1 + calc.Nr2;

            return calc.Resultado;
        }

        public int Subtrair(Calculadora calc)
        {
            calc.Resultado = calc.Nr1 - calc.Nr2;

            return calc.Resultado;
        }
        public int Dividir(Calculadora calc)
        {
            calc.Resultado = calc.Nr1 / calc.Nr2;

            return calc.Resultado;
        }
        public int Multiplicar(Calculadora calc)
        {
            calc.Resultado = calc.Nr1 * calc.Nr2;

            return calc.Resultado;
        }

    }
}