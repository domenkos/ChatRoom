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

        public void osvezi()
        {
            HashSet<String> prijavljeni = (HashSet<String>)Application["vsi_prijavljeni"];
            Hashtable imena = (Hashtable)Application["names"];
            Users.Items.Clear();
            foreach (var oseba in prijavljeni)
            {
                Users.Items.Add((string)imena[oseba]);
            }

        }
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
                Application["names"] = imena;
                string vpisani_uporabnik = (string)imena[(string)Session["vpisaniup"]];
                CurrentUser.Text = "Prijavljeni ste kot: " + vpisani_uporabnik;
                osvezi();
            }
            if (Application["sporocila"] == null)
                Application["sporocila"] = "";

        }

        protected void Refresh_Click(object sender, EventArgs e)
        {
            osvezi();
            String sp = (string)Application["sporocila"];
            Messages.Items.Clear();
            string[] msgs = sp.Split(',');
            foreach (string word in msgs)
            {
                Messages.Items.Add(word);
            }


        }

        protected void Send_Click(object sender, EventArgs e)
        {
            String sp = (string)Application["sporocila"];

            Hashtable imena = (Hashtable)Application["names"];
            
            string vpisani_uporabnik = (string)imena[(string)Session["vpisaniup"]];
            sp += vpisani_uporabnik + ":" + Message.Text + ",";

            Application["sporocila"] = sp;
            Messages.Items.Clear();
            string[] msgs = sp.Split(',');
            foreach(string word in msgs)
            {
                Messages.Items.Add(word);
            }
            Message.Text = "";

        }

        protected void Messages_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Users_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Logout_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            HashSet<String> pom = (HashSet<String>)Application["vsi_prijavljeni"];
            pom.Remove((string)Session["vpisaniup"]);
            Application["vsi_prijavljeni"] = pom;
            Response.Redirect("Login.aspx?");

        }

        protected void Message_TextChanged(object sender, EventArgs e)
        {

        }
    }
}