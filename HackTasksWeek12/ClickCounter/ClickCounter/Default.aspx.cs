using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClickCounter
{
    public partial class Default : System.Web.UI.Page
    {
        protected string name;


        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "" || TextBox1.Text=="Re-enter name")
            {
                TextBox1.Text = "Re-enter name";            }
            else
            {
                Session["Name"] = name;
                Session["click"] = 0;
                Application["allclicks"] = info.alltimeclicks;
                Response.Redirect("ClickCounter.aspx");
            }
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            name = TextBox1.Text;
            Session["Name"] = name;
        }
    }
}