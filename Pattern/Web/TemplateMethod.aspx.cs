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

using Pattern.TemplateMethod;

public partial class TemplateMethod : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        AbstractMessageTemplate m = new XmlMessage("user");
        Response.Write(m.TemplateMethodGet()[0].Message + " " + m.TemplateMethodGet()[0].PublishTime.ToString());
        Response.Write("<br />");

        m = new SqlMessage("admin");
        Response.Write(m.TemplateMethodGet()[0].Message + " " + m.TemplateMethodGet()[0].PublishTime.ToString());
        Response.Write("<br />");
    }
}
