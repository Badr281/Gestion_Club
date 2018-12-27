using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Gestion_club
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        Connection cn = new Connection();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            // re
            cn.connecter();

            int id_adherent = cn.getAdherent(TextBox1.Text, TextBox2.Text);
            int payer = RadioButton1.Checked == true ? 1 : 0;
            

            cn.deconnecter();

        }

        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //if (RadioButton1.Checked)
            //{
            //    string value =
            //}
        }
    }
}