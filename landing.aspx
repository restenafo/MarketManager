<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="landing.aspx.cs" Inherits="MarketManager.landing" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link href="css/bootstrap.min.css" rel="stylesheet" />
    <link href="css/style.css" rel="stylesheet" />
    <title>Control Panel</title>
</head>
<body>
    <div class="container">
        <form id="form1" runat="server">
            <div>
                <asp:Label ID="LBLwelcome" CssClass="d-flex justify-content-center" runat="server" Text=""></asp:Label>

            </div>
            <div class="boxControlPanel">
                <div class="d-flex justify-content-center">
                    <asp:Button ID="BTNgestioneDipendenti" CssClass="btn btn-lg btnColorOne pulsante invisibile" runat="server" Text="Gestione Dipendenti" OnClick="BTNgestioneDipendenti_Click" />
                    <asp:Button ID="BTNgestioneMagazzino" CssClass="btn btn-lg btnColorThree pulsante invisibile" runat="server" Text="Gestione Magazzino" />
                    <asp:Button ID="BTNgestioneCasse" CssClass="btn btn-lg btnColorTwo pulsante invisibile" runat="server" Text="Gestione Casse" />
                </div>
                <div class="d-flex justify-content-center">
                    <asp:Button ID="BTNgestioneScaffali" CssClass="btn btn-lg btnColorFive pulsante invisibile" runat="server" Text="Gestione Scaffali" />
                    <asp:Button ID="BTNgestioneArticoliInVendita" CssClass="btn btn-lg btnColorSix pulsante invisibile" runat="server" Text="Gestione Articoli" />
                    <asp:Button ID="BTNgestioneContabile" CssClass="btn btn-lg btnColorSeven pulsante invisibile" runat="server" Text="Gestione Contabile" />
                </div>
            </div>
        </form>
    </div>
</body>
</html>
