using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace Gestion_club
{
    public class Connection
    {
         string chaine = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Gestion_club;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlConnection  cnx;



        public  void connecter()
        {
            cnx = new SqlConnection(chaine);
            cnx.Open();
        }
        public   void deconnecter()
        {
           
            cnx.Close();
            cnx.Dispose();
        }
        public SqlDataReader lecture(string nom_table)
        {
            string req = "Select * from " + nom_table + " ";
            SqlCommand cm = new SqlCommand(req,cnx);
            return cm.ExecuteReader();

        }
        public  int ajouterClient(string nom, string tel,string prenom="", string adre ="")
        {
            string req = "insert into adherent OUTPUT INSERTED.ID values('" + nom + "','" + prenom + "','" + tel + "','" + adre + "') ";  // OUTPUT  : la dernier  ligne retiu
            SqlCommand cm = new SqlCommand(req,cnx);
            cm.ExecuteNonQuery();
            return (Int32)cm.ExecuteScalar();

        }

      public  int ajouterAbonnement(int id_adherent, DateTime date_ab , string sport)
        {
            try
            {

                string req = "insert into Abonnement(id_abonne,date_debut,type_sport)  values('" + id_adherent + "','" + Convert.ToDateTime(date_ab.Date.ToString("MM/dd/yyyy")) + "','" + sport + "' ";
                SqlCommand cm = new SqlCommand(req, cnx);
                return cm.ExecuteNonQuery();
            }
            catch (Exception E) {
                throw new Exception(E.Message);
            }

        }
        
        public int getAdherent(string nom, string prenom)
        {
            string req = "Select id from adherent where nom ='" + nom + "'  and prenom = '" + prenom + "'";
            SqlCommand cm = new SqlCommand(req, cnx);
            return (int)cm.ExecuteScalar();

        }
        public int payer(int id_adherent,int paie,int mois)
        {
            string req = "insert into payemens values('" + id_adherent + "','" + paie + "','" + mois + "')";
            SqlCommand cm = new SqlCommand(req, cnx);
            return cm.ExecuteNonQuery();

        }
   


    }
}