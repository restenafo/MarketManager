using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MarketManager
{
    public partial class gestioneDipendenti : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //DA RIATTIVARE LA SEZIONE SOTTO
            if (!IsPostBack)
            {
                formInserimentoUtenti.Attributes["class"] = "invisibile";
                tableListEmployers.Attributes["class"] = "invisibile";
            }
            //if ((bool)Session["administrator"])
            //{

            //}
            //else
            //{
            //    LBLheaderPersonale.CssClass = "invisibile";
            //    BTNinserisciDipendente.CssClass = "invisibile";
            //    BTNvisualizzaDipendenti.CssClass = "invisibile";
            //}
        }

        protected void BTNinserisciDipendente_Click(object sender, EventArgs e)
        {
            formInserimentoUtenti.Attributes["class"] = "visibile";
        }

        protected void BTNvisualizzaDipendenti_Click(object sender, EventArgs e)
        {
            tableListEmployers.Attributes["class"] = "visibile";
            ReloadTable();
        }

        protected void BTNaggiungi_Click(object sender, EventArgs e)
        {
            Dipendente oDipendente = new Dipendente();
            oDipendente.nome = TXTnomeDipendente.Text;
            oDipendente.cognome = TXTcognomeDipendente.Text;
            oDipendente.matricola = Guid.NewGuid().ToString("N").Substring(10, 10);
            oDipendente.codiceFiscale = TXTcodiceFiscale.Text;
            oDipendente.dataNascita = TXTdataDiNascita.Text;
            oDipendente.luogoNascita = TXTluogoDiNascita.Text;
            oDipendente.nazionalita = TXTnazionalita.Text;

            DipendenteDAO oDipendenteDao = new DipendenteDAO();
            oDipendenteDao.InsertDipendente(oDipendente);
            FormClear();
        }

        protected void BTNannulla_Click(object sender, EventArgs e)
        {
            FormClear();
            formInserimentoUtenti.Attributes["class"] = "invisibile";

        }

        /// <summary>
        /// Reinizializza il form d'inserimento dei dati del Dipendente
        /// </summary>
        private void FormClear()
        {
            TXTnomeDipendente.Text = "";
            TXTcognomeDipendente.Text = "";
            TXTcodiceFiscale.Text = "";
            TXTdataDiNascita.Text = "";
            TXTluogoDiNascita.Text = "";
            TXTnazionalita.Text = "";
            
        }

        /// <summary>
        /// Rigenera la tabella dei Dipendenti
        /// </summary>
        private void ReloadTable()
        {
            TBLdipendenti.Rows.Clear();
            List<Dipendente> listaDipendente = new List<Dipendente>();
            DipendenteDAO oDipendenteDao = new DipendenteDAO();
            listaDipendente = oDipendenteDao.GetAllDipendenti();
            foreach (Dipendente d in listaDipendente)
            {
                TableCell tc1 = new TableCell();
                TableCell tc2 = new TableCell();
                TableCell tc3 = new TableCell();
                TableCell tc4 = new TableCell();
                TableCell tc5 = new TableCell();
                TableCell tc6 = new TableCell();
                TableCell tc7 = new TableCell();

                tc1.Text = d.nome;
                tc2.Text = d.cognome;
                tc3.Text = d.codiceFiscale;
                tc4.Text = d.dataNascita;
                tc5.Text = d.luogoNascita;
                tc6.Text = d.nazionalita;
                tc7.Text = d.matricola;

                //Button oUpdateButton = new Button();
                //oUpdateButton.CssClass = "btn btn-sm btn-warning ombraPulsante";
                //oUpdateButton.Text = "Modifica";
                //oUpdateButton.Attributes["id_Dipendente"] = d.id;
                //oUpdateButton.Click += new EventHandler(ModificaDipendente);
                //tc3.Controls.Add(oUpdateButton);

                //Button oDeleteButton = new Button();
                //oDeleteButton.CssClass = "btn btn-sm btn-danger ombraPulsante";
                //oDeleteButton.Text = "Elimina";
                //oDeleteButton.Attributes["id_Dipendente"] = d.id;
                //oDeleteButton.Click += new EventHandler(CancellaDipendente);
                ////oDeleteButton.Click += CancellaDipendente;
                //tc4.Controls.Add(oDeleteButton);

                TableRow tr = new TableRow();
                tr.Cells.Add(tc1);
                tr.Cells.Add(tc2);
                tr.Cells.Add(tc3);
                tr.Cells.Add(tc4);
                tr.Cells.Add(tc5);
                tr.Cells.Add(tc6);
                tr.Cells.Add(tc7);

                TBLdipendenti.Rows.Add(tr);
            }
        }
        public void ModificaDipendente(object sender, EventArgs e)
        {
            string id = ((Button)sender).Attributes["id_Dipendente"];
            Response.Redirect("users.aspx?userId=" + id);
        }

        public void CancellaDipendente(object sender, EventArgs e)
        {
            string id = ((Button)sender).Attributes["id_Dipendente"];
            new DipendenteDAO().DeleteDipendente(id);
            ReloadTable();
        }

        /// <summary>
        /// Resetta i campi del Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void BTNazzera_Click(object sender, EventArgs e)
        {
            FormClear();                   
        }

        protected void BTNmodifica_Click(object sender, EventArgs e)
        {

        }

        protected void BTNesci_Click(object sender, EventArgs e)
        {
            tableListEmployers.Attributes["class"] = "invisibile";

        }
    }
}