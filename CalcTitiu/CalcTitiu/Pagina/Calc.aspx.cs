using System;
using CalcTitiu.App_Code.Model;
using CalcTitiu.App_Code.Servico;

namespace CalcTitiu.Pagina
{
    public partial class Calc : System.Web.UI.Page
    {
        private static Calculadora calculadora = new Calculadora();
        private static CalculadoraService calculadoraService = new CalculadoraService();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                nr3.Visible = false;
            }
        }

        protected void btnSoma_Click(object sender, EventArgs e)
        {
            gravaCalc(Convert.ToInt32(nr1.Text), Convert.ToInt32(nr2.Text));

            txtResultado.Text = $"<div class='text-primary form-control col-12'> Resultado = {calculadoraService.Somar(calculadora)} </div>";
            LimpaTudo();
        }

        protected void btnSubtracao_Click(object sender, EventArgs e)
        {

            gravaCalc(Convert.ToInt32(nr1.Text), Convert.ToInt32(nr2.Text));

            txtResultado.Text = $"<div class='text-primary form-control col-12'> Resultado = {calculadoraService.Subtrair(calculadora)} </div>";
            LimpaTudo();
        }

        protected void btnDivisao_Click(object sender, EventArgs e)
        {
            gravaCalc(Convert.ToInt32(nr1.Text), Convert.ToInt32(nr2.Text));

            txtResultado.Text = $"<div class='text-primary form-control col-12'> Resultado = {calculadoraService.Dividir(calculadora)} </div>";
            LimpaTudo();
        }

        protected void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            gravaCalc(Convert.ToInt32(nr1.Text), Convert.ToInt32(nr2.Text));

            txtResultado.Text = $"<div class='text-primary form-control col-12'> Resultado = {calculadoraService.Multiplicar(calculadora)} </div>";
            LimpaTudo();
        }

        void LimpaTudo()
        {
            nr1.Text = "";
            nr2.Text = "";
            nr3.Text = "";
        }

        private void gravaCalc(int a, int b)
        {
            calculadora.Nr1 = a;
            calculadora.Nr2 = b;
        }

        protected void btnCalcularEquacao_Click(object sender, EventArgs e)
        {
            int a, b, c;
            double delta, x1, x2;

            a = Convert.ToInt32(nr1.Text);
            b = Convert.ToInt32(nr2.Text);
            c = Convert.ToInt32(nr3.Text);            

            delta = Math.Pow(b, 2) - 4 * a * c;

            if (a == 0)
            {
                txtResultado.Text = "<div class='text-primary form-control col-12'> Resultado = o A não pode ser igual a 0 </div>";
                LimpaTudo();
            }
            else if (delta == 0)
            {
                double resultado = (-b) / (2 * a);

                txtResultado.Text = $"<div class='text-primary form-control col-12'> Resultado = {resultado} </div>";
                LimpaTudo();
            }
            else if(delta < 0)
            {
                txtResultado.Text = "<div class='text-primary form-control col-12'> Resultado = Não possuí valores reais </div>";
                LimpaTudo();
            }
            else
            {
                x1 = (-(b) + Math.Sqrt(delta)) / (2 * a);
                x2 = (-(b) - Math.Sqrt(delta)) / (2 * a);

                txtResultado.Text = $"<div class='text-primary form-control col-12'> Resultado = X1:{x1} X2:{x2} </div>";
                LimpaTudo();
            }
        }

        protected void btnEquacao_Click(object sender, EventArgs e)
        {
            nr3.Visible = true;
        }
    }
}