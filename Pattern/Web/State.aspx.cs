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

using Pattern.State;

public partial class State : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Message m = new Message("admin");
        Response.Write(m.Insert(new MessageModel("插入", DateTime.Now)));
        Response.Write("<br />");
        Response.Write(m.Get()[0].Message + " " + m.Get()[0].PublishTime.ToString());
        Response.Write("<br />");

        m = new Message("user");
        Response.Write(m.Insert(new MessageModel("插入", DateTime.Now)));
        Response.Write("<br />");
        Response.Write(m.Get()[0].Message + " " + m.Get()[0].PublishTime.ToString());
        Response.Write("<br />");
    }
}
