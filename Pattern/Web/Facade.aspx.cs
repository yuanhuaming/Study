using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

using Pattern.Facade;

public partial class Facade : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Message m = new Message("user");
        Response.Write(m.Get()[0].Message + " " + m.Get()[0].PublishTime.ToString());
        Response.Write("<br />");

        m = new Message("admin");
        Response.Write(m.Get()[0].Message + " " + m.Get()[0].PublishTime.ToString());
        Response.Write("<br />");
    }
}
