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

using Pattern.Adapter;

public partial class Adapter : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        IMessage m;

        m = new Message();
        Response.Write("类适配器方式<br />");
        Response.Write(m.Add(new MessageModel("插入", DateTime.Now)));
        Response.Write("<br />");
        Response.Write(m.Select()[0].Message + " " + m.Select()[0].PublishTime.ToString());
        Response.Write("<br /><br />");

        m = new Message2();
        Response.Write("对象适配器方式<br />");
        Response.Write(m.Add(new MessageModel("插入", DateTime.Now)));
        Response.Write("<br />");
        Response.Write(m.Select()[0].Message + " " + m.Select()[0].PublishTime.ToString());
        Response.Write("<br />");
    }
}
