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

using Pattern.Decorator;

public partial class Decorator : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        AbstractMessage message = new SqlMessage();

        AbstractMessageWrapper amr = new CheckUserWrapper(message);

        Response.Write(amr.Get()[0].Message + " " + amr.Get()[0].PublishTime.ToString());
        Response.Write("<br />");

        AbstractMessageWrapper amr2 = new CheckInputWrapper(message);

        Response.Write(amr2.Get()[0].Message + " " + amr2.Get()[0].PublishTime.ToString());
        Response.Write("<br />");

        AbstractMessageWrapper amr3 = new CheckUserWrapper(message);
        AbstractMessageWrapper amr4 = new CheckInputWrapper(amr3);

        Response.Write(amr4.Get()[0].Message + " " + amr4.Get()[0].PublishTime.ToString());
        Response.Write("<br />");
    }
}
