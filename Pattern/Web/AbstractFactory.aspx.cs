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

using Pattern.AbstractFactory;

public partial class AbstractFactory : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        AbstractMessageFactory amf = new SqlMessageFactory();

        Message m = new Message(amf);

        Response.Write(m.Insert("admin", "Sql方式", DateTime.Now));
        Response.Write("<br />");

        amf = new XmlMessageFactory();

        m = new Message(amf);

        Response.Write(m.Insert("user", "Xml方式", DateTime.Now));
    }
}
