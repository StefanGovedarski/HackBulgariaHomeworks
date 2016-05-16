using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClickCounter
{
    public partial class ClickCounter : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = "Welcome, " + Session["Name"];
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["click"] = (int)Session["click"] + 1;
            Application["allclicks"] = (int)Application["allclicks"] + 1;
            
        }
        protected void button2_click(object sender, EventArgs e)
        {
            info.alltimeclicks = (int)Application["allclicks"];
            Response.Redirect("Default.aspx");
        }

    }
}