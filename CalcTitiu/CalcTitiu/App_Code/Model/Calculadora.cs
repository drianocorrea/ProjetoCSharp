using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CalcTitiu.App_Code.Model
{
    public class Calculadora
    {
        private int nr1, nr2, resultado;

        public int Nr1 { get => nr1; set => nr1 = value; }
        public int Nr2 { get => nr2; set => nr2 = value; }
        public int Resultado { get => resultado; set => resultado = value; }
    }
}