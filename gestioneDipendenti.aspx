<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="gestioneDipendenti.aspx.cs" Inherits="MarketManager.gestioneDipendenti" %>

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
            <div class="d-flex justify-content-center">
                <asp:Label ID="LBLwelcome" runat="server" Text=""></asp:Label>

            </div>
            <div>
                <asp:Label ID="LBLheaderPersonale" CssClass="d-flex justify-content-center visibile" runat="server" Text="GESTIONE DEL PERSONALE"></asp:Label>
                <div class="d-flex justify-content-center">
                    <asp:Button ID="BTNinserisciDipendente" CssClass="btn btn-lg btnColorOne pulsante visibile" runat="server" Text="Inserisci Dipendente" OnClick="BTNinserisciDipendente_Click" />
                    <asp:Button ID="BTNvisualizzaDipendenti" CssClass="btn btn-lg btnColorTwo pulsante visibile" runat="server" Text="Visualizza Personale" OnClick="BTNvisualizzaDipendenti_Click" />
                    
                </div>
                
                <div id="formInserimentoUtenti" runat="server">
                    <div>
                        <h5 id="titoloInserisciDati" class="d-flex justify-content-center">INSERISCI I DATI DEL DIPENDENTE</h5>
                        <asp:TextBox ID="TXTnomeDipendente" CssClass="d-flex justify-content-center" runat="server" placeholder="Nome"></asp:TextBox>
                        <asp:TextBox ID="TXTcognomeDipendente" CssClass="d-flex justify-content-center" runat="server" placeholder="Cognome"></asp:TextBox>
                        <asp:TextBox ID="TXTcodiceFiscale" CssClass="d-flex justify-content-center" runat="server" placeholder="Codice Fiscale"></asp:TextBox>
                        <asp:TextBox ID="TXTdataDiNascita" CssClass="d-flex justify-content-center" runat="server" placeholder="Data di Nascita"></asp:TextBox>
                        <asp:TextBox ID="TXTluogoDiNascita" CssClass="d-flex justify-content-center" runat="server" placeholder="Luogo di Nascita"></asp:TextBox>
                        <asp:TextBox ID="TXTnazionalita" CssClass="d-flex justify-content-center" runat="server" placeholder="Nazionalità"></asp:TextBox>
                    </div>
                    <div>
                        <asp:Button ID="BTNaggiungi" CssClass="btn btn-success pulsantePersonale" runat="server" Text="AGGIUNGI" OnClick="BTNaggiungi_Click" />
                        <asp:Button ID="BTNazzera" CssClass="btn btn-warning pulsantePersonale" runat="server" Text="AZZERA" />
                        <asp:Button ID="BTNannulla" CssClass="btn btn-danger pulsantePersonale" runat="server" Text="ESCI" OnClick="BTNannulla_Click" />
                    </div>
                </div>
                <div id="tableListEmployers" runat="server">
                    <div>
                    <asp:Table ID="TBLdipendenti" CssClass="table table-borderless" runat="server"></asp:Table>
                        </div>
                    <div class="d-flex justify-content-center">
                        <asp:Button ID="BTNmodifica" CssClass="btn btn-warning pulsantePersonale" runat="server" Text="Modifica" OnClick="BTNmodifica_Click" />
                        <asp:Button ID="BTNesci" CssClass="btn btn-danger pulsantePersonale" runat="server" Text="Esci" OnClick="BTNesci_Click" />
                    </div>
                </div>
            </div>
        </form>
    </div>
</body>
</html>
