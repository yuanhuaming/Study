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

using Pattern.Visitor;

public partial class Visitor : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Pattern.Visitor.Messages m = new Pattern.Visitor.Messages();

        m.Attach(new SqlMessage(new MessageModel("插入", DateTime.Now)));
        m.Attach(new XmlMessage(new MessageModel("插入", DateTime.Now)));

        Response.Write(m.Accept(new InsertVisitor()));
        Response.Write(m.Accept(new GetVisitor()));
    }
}
