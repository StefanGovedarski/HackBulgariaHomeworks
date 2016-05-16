using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace ClickCounter
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
        }
        protected void Application_End(object sender, EventArgs e)
        {
            info.alltimeclicks += (int)Application["allclicks"];
        }
    }
    public static class info
    {
        private static int clicks;
        public static int alltimeclicks { get { return clicks; } set { clicks = value; } }
    }
}