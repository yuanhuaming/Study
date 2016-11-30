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

using Pattern.Proxy;

public partial class Proxy : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        MessageProxy m = new MessageProxy();
        Response.Write(m.Insert(new MessageModel("插入", DateTime.Now)));
        Response.Write("<br />");
        Response.Write(m.Get()[0].Message + " " + m.Get()[0].PublishTime.ToString());
    }
}
