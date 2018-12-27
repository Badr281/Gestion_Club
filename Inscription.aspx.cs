using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Gestion_club
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        Gestion_clubEntities1 db = new Gestion_clubEntities1();
        Connection cnn = new Connection();
        public string Date()
        {
            
            return  Calendar1.SelectedDate.ToString("MM/dd/yyyy");



        }

        protected void Page_Load(object sender, EventArgs e)
        {
         //DropDownList2.DataSource=
        }
     


        protected void Ajouter_Click(object sender, EventArgs e)
        {
            //string dateString = this.Calendar1.SelectedDate.ToString("MM/dd/yyyy");
            //DateTime Date = Convert.ToDateTime(dateString.ToString());
            //cnn.connecter();
            //int  id_adherent =cnn.ajouterClient(nom.Text, prenom.Text, telephone.Text,adresse.Text) ;
            //cnn.ajouterAbonnement(id_adherent,Date, DropDownList1.SelectedValue);
            //cnn.deconnecter();
            // Initialisation de la base de donées
            Gestion_clubEntities1 db = new Gestion_clubEntities1();
            adherent a1 = new adherent()
            {
                nom = nom.Text,
                prenom = prenom.Text,
                adresse = adresse.Text,
                tel = telephone.Text


            };
            //ajouter l'adtherenet
            db.adherents.Add(a1);
           
            //Sauvegardage d'opération
            db.SaveChanges();


        }

        protected void modifier_Click(object sender, EventArgs e)
        {
            //Trouver l'adtherent
            adherent adherent_modifier = db.adherents.Find(DropDownList2.SelectedIndex);
            //affecter la valeur
            adherent_modifier.nom = nom.Text;
            //sauvegadage des données
            db.SaveChanges();    

           


        }

        protected void supprimer_Click(object sender, EventArgs e)
        {
            //adherent adherent_modifier = db.adherents.Find(Int32.Parse(DropDownList2.SelectedIndex));
            //db.adherents.Remove(adherent_modifier);
            //db.SaveChanges();
        }

        protected void Calendar2_SelectionChanged(object sender, EventArgs e)
        {
            TextBox1.Text = Calendar2.SelectedDate.ToShortDateString();
            Calendar2.Visible = false;
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                Calendar2.Visible = true;
            }

        }
        protected void afficher_Click(object sender, EventArgs e)
        {
          



        }

        protected void Button2_Click(object sender, EventArgs e)
        {
           var req = from s in db.abonnements
                     from ab in s.payements
                    where ab.payer == 1 &&
                     ab.mois_courant == TextBox1.Text
                    select new
                    {
                        
                    }

        }
    }
}