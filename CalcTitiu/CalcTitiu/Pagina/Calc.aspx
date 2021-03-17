<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Calc.aspx.cs" Inherits="CalcTitiu.Pagina.Calc" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="../Content/bootstrap.min.css" rel="stylesheet" />
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="col-12 mt-2">
                <div class="col-12 row">
                    <div class="col-4">
                        <asp:TextBox runat="server" ID="nr1" placeholder="Digite o primeiro número..." CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="col-4">
                        <asp:TextBox runat="server" ID="nr2" placeholder="Digite o segundo número..." CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="col-4">
                        <asp:TextBox runat="server" ID="nr3" placeholder="Digite o terceiro número..." CssClass="form-control"></asp:TextBox>
                    </div>
                </div>
                <hr />
                <div class="col-12">
                    <div class="row">
                        <div class="col-2">
                            <asp:Button runat="server" ID="btnSoma" Text="Soma" OnClick="btnSoma_Click" CssClass="btn btn-block btn-primary" />
                        </div>
                        <div class="col-2">
                            <asp:Button runat="server" ID="btnSubtracao" Text="Subtração" OnClick="btnSubtracao_Click" CssClass="btn btn-block btn-primary" />
                        </div>
                        <div class="col-2">
                            <asp:Button runat="server" ID="btnDivisao" Text="Divisão" OnClick="btnDivisao_Click" CssClass="btn btn-block btn-primary" />
                        </div>
                        <div class="col-2">
                            <asp:Button runat="server" ID="btnMultiplicacao" Text="Multiplicação" OnClick="btnMultiplicacao_Click" CssClass="btn btn-block btn-primary" />
                        </div>
                        <div class="col-2">
                            <asp:Button runat="server" ID="btnCalcularEquacao" Text="Calcular Equação" OnClick="btnCalcularEquacao_Click" CssClass="btn btn-block btn-primary" />
                        </div>
                        <div class="col-2">
                            <asp:Button runat="server" ID="btnEquacao" Text="Equação" OnClick="btnEquacao_Click" CssClass="btn btn-block btn-primary" />
                        </div>

                    </div>
                </div>
                <hr />
                <div class="col-12">
                    <asp:Literal ID="txtResultado" runat="server"></asp:Literal>
                </div>
            </div>
        </div>
    </form>
    <script src="../Scripts/bootstrap.min.js"></script>
</body>
</html>
