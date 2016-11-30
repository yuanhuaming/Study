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

using Pattern.Builder;

public partial class Builder : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Message m = new Message();

        AbstractMessageBuilder amb = new SqlMessageBuilder();
        m.Construct(amb, new MessageModel("插入", DateTime.Now));

        Response.Write(amb.Operation.GetResult());

        amb = new XmlMessageBuilder();
        m.Construct(amb, new MessageModel("插入", DateTime.Now));

        Response.Write(amb.Operation.GetResult());
    }
}
