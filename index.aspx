<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="MarketManager.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link href="css/bootstrap.min.css" rel="stylesheet" />
    <link href="css/style.css" rel="stylesheet" />
    <title>MarketManager v0.1</title>
</head>
<body>
    <div class="container">

        <form id="form1" runat="server">
            <div class="d-flex justify-content-center boxLogin">
                <div class="justify-content-center verticalCenter">
                    <h4 class="loginBoxTitle">INSERISCI LE TUE CREDENZIALI</h4>
                    <p class="d-flex justify-content-center"><asp:TextBox ID="TXTusername" runat="server" placeholder="Username"></asp:TextBox></p>
                    <p class="d-flex justify-content-center"><asp:TextBox ID="TXTpassword" runat="server" placeholder="Password" TextMode="Password"></asp:TextBox></p>
                    <p class="d-flex justify-content-center"><asp:Button ID="BTNlogin" CssClass="justify-content-center" runat="server" Text="Login" OnClick="BTNlogin_Click" /></p>
                </div>
            </div>
        </form>


    </div>
</body>
</html>
