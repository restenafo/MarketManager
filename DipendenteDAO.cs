using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace MarketManager
{
    public class DipendenteDAO
    {
        public List<Dipendente> GetAllDipendenti()
        {
            DBConnection c = new DBConnection();
            DataTable dt = new DataTable();

            string qry = "SELECT * FROM DIPENDENTI WHERE ABILITATO = 1";
            dt = c.DoQuerySelect(qry);

            List<Dipendente> listaDipendenti = new List<Dipendente>();
            foreach (DataRow tr in dt.Rows)
            {
                Dipendente oDipendente = new Dipendente();
                oDipendente.id = tr["ID"].ToString().ToUpper();
                oDipendente.nome = tr["NOME"].ToString().ToUpper();
                oDipendente.cognome = tr["COGNOME"].ToString().ToUpper();
                oDipendente.codiceFiscale = tr["CODICEFISCALE"].ToString().ToUpper();
                oDipendente.dataNascita = Convert.ToDateTime(tr["DATADINASCITA"]).ToString("dd-MM-yyyy");/* tr["DATADINASCITA"].ToString().ToUpper();*/
                oDipendente.luogoNascita = tr["LUOGODINASCITA"].ToString().ToUpper();
                oDipendente.nazionalita = tr["NAZIONALITA"].ToString().ToUpper();
                oDipendente.matricola = tr["NUMEROMATRICOLA"].ToString().ToUpper();
                //oDipendente.abilitato=tr["ABILITATO"];

                listaDipendenti.Add(oDipendente);
            }
            return listaDipendenti;
        }

        public void InsertDipendente(Dipendente oDipendente)
        {
            DBConnection c = new DBConnection();
            DataTable dt = new DataTable();
            string qry = string.Format("INSERT INTO DIPENDENTI (NOME, COGNOME, CODICEFISCALE, DATADINASCITA, LUOGODINASCITA, NAZIONALITA, NUMEROMATRICOLA, ABILITATO) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}', 1)", oDipendente.nome, oDipendente.cognome, oDipendente.codiceFiscale, oDipendente.dataNascita, oDipendente.luogoNascita, oDipendente.nazionalita, oDipendente.matricola);
            c.ExecuteNonQuery(qry);
        }

        public void UpdateDipendente(Dipendente oDipendente)
        {
            DBConnection c = new DBConnection();
            string qry = string.Format("UPDATE DIPENDENTI SET NOME = '{0}', COGNOME = '{1}' where ID = {2}", oDipendente.nome, oDipendente.cognome, oDipendente.id);
            c.ExecuteNonQuery(qry);
        }

        public Dipendente getDipendenteById(string id)
        {
            DBConnection c = new DBConnection();
            DataTable dt = new DataTable();

            string qry = "SELECT * FROM DIPENDENTI WHERE ID = " + id;
            dt = c.DoQuerySelect(qry);

            if (dt.Rows.Count > 0)
            {
                Dipendente oDipendente = new Dipendente();
                oDipendente.id = dt.Rows[0]["ID"].ToString().ToUpper();
                oDipendente.nome = dt.Rows[0]["NOME"].ToString().ToUpper();
                oDipendente.cognome = dt.Rows[0]["COGNOME"].ToString().ToUpper();
                oDipendente.codiceFiscale = dt.Rows[0]["CODICEFISCALE"].ToString().ToUpper();
                oDipendente.dataNascita = dt.Rows[0]["DATADINASCITA"].ToString().ToUpper();
                oDipendente.luogoNascita = dt.Rows[0]["LUOGONASCITA"].ToString().ToUpper();
                oDipendente.nazionalita = dt.Rows[0]["NAZIONALITA"].ToString().ToUpper();
                oDipendente.matricola = dt.Rows[0]["NUMEROMATRICOLA"].ToString().ToUpper();
                //oDipendente.abilitato=dt.Rows[0]["ABILITATO"];


                return oDipendente;
            }
            else
            {
                return new Dipendente();
            }
        }

        public void DeleteDipendente(string id)
        {
            DBConnection c = new DBConnection();
            DataTable dt = new DataTable();
            string qry = "UPDATE DIPENDENTI SET ABILITATO = 0 WHERE ID = " + id;
            c.ExecuteNonQuery(qry);
        }

        public List<Dipendente> GetAllDeletedUtenti()
        {
            DBConnection c = new DBConnection();
            DataTable dt = new DataTable();

            string qry = "SELECT * FROM DIPENDENTI WHERE ABILITATO = 0";
            dt = c.DoQuerySelect(qry);

            List<Dipendente> listaUtenti = new List<Dipendente>();
            foreach (DataRow tr in dt.Rows)
            {
                Dipendente oDipendente = new Dipendente();
                oDipendente.id = tr["ID"].ToString();
                oDipendente.nome = tr["NOME"].ToString();
                oDipendente.cognome = tr["COGNOME"].ToString();

                listaUtenti.Add(oDipendente);
            }
            return listaUtenti;
        }

        public void UndeleteDipendente(string id)
        {
            DBConnection c = new DBConnection();
            DataTable dt = new DataTable();
            string qry = "UPDATE DIPENDENTI SET ABILITATO = 1 WHERE ID =" + id;
            c.ExecuteNonQuery(qry);
        }

    }
}