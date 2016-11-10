using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Seminar1
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Application["vsi"] == null)
            {
                Hashtable uporabniki = new Hashtable();
                uporabniki.Add("63150154", "Geslo.Student");
                uporabniki.Add("murkod", "Geslo.Programer");
                uporabniki.Add("admin", "Geslo.Admin");
                Application["vsi"] = uporabniki;
                var trenutni = new HashSet<String>();
                Application["vsi_prijavljeni"] = trenutni;
            }

        }

        protected void Username_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Password_TextChanged(object sender, EventArgs e)
        {

        }

        protected void LoginBtn_Click(object sender, EventArgs e)
        {
            String user = "";
            String pw = "";
            user = Username.Text;
            pw = Password.Text;

            if (user == "" || pw == "")
            {
                error.Text = "Vnesite uporabnisko ime in geslo";

            }
            else
            {
                Hashtable uporabniki = (Hashtable)Application["vsi"];

                if (uporabniki.ContainsKey(user))
                {
                    if (uporabniki[user].Equals(pw))
                    {
                        Session["vpisaniup"] = user;
                        HashSet<String> trenutni = (HashSet < String > )Application["vsi_prijavljeni"];
                        trenutni.Add(user);
                        Application["vsi_prijavljeni"] = trenutni;
                        Response.Redirect("Chat.aspx?");
                    }
                    else
                        error.Text = "Ne ujema se uporabnisko ime in geslo";

                }
                else
                    error.Text = "Uporabnik ne obstaja";
            }
        }
    }
}