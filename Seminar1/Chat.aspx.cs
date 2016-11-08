using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Seminar1
{
    public partial class Chat : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["vpisaniup"] == null)
                Response.Redirect("Login.aspx?");
            else
            {
                Hashtable imena = new Hashtable();
                imena.Add("63150154","Domen Kos");
                imena.Add("murkod", "Murko Damjanovič");
                imena.Add("admin", "Slavoj Žužek");
                string vpisani_uporabnik = (string)imena[(string)Session["vpisaniup"]];
                CurrentUser.Text = "Prijavljeni ste kot: " + vpisani_uporabnik;
            }

        }

        protected void Refresh_Click(object sender, EventArgs e)
        {
            Response.Write(Application["vsi_prijavljeni"]);

        }

        protected void Send_Click(object sender, EventArgs e)
        {

        }

        protected void Messages_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Users_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Logout_Click(object sender, EventArgs e)
        {

        }

        protected void Message_TextChanged(object sender, EventArgs e)
        {

        }
    }
}