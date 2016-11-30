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

using Pattern.FactoryMethod;

public partial class FactoryMethod : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        AbstractMessageFactory amf = new SqlMessageFactory();
        AbstractMessage am = amf.CreateMessage();

        Response.Write(am.Insert(new MessageModel("插入", DateTime.Now)));
        Response.Write("<br />");
        Response.Write(am.Get()[0].Message + " " + am.Get()[0].PublishTime.ToString());
        Response.Write("<br />");


        amf = new XmlMessageFactory();
        am = amf.CreateMessage();

        Response.Write(am.Insert(new MessageModel("插入", DateTime.Now)));
        Response.Write("<br />");
        Response.Write(am.Get()[0].Message + " " + am.Get()[0].PublishTime.ToString());
    }
}
