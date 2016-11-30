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

using Pattern.Mediator;

public partial class Mediator : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        AbstractMessageMediator messageMediator = new MessageMediator();

        AbstractMessage user1 = new SqlMessage("user1");
        AbstractMessage user2 = new SqlMessage("user2");
        AbstractMessage user3 = new XmlMessage("user3");
        AbstractMessage user4 = new XmlMessage("user4");

        messageMediator.Register(user1);
        messageMediator.Register(user2);
        messageMediator.Register(user3);
        messageMediator.Register(user4);

        Response.Write(user1.Send("user2", new MessageModel("你好！", DateTime.Now)));
        Response.Write("<br />");
        Response.Write(user2.Send("user1", new MessageModel("我不好！", DateTime.Now)));
        Response.Write("<br />");
        Response.Write(user1.Send("user2", new MessageModel("不好就不好吧。", DateTime.Now)));
        Response.Write("<br />");
        Response.Write(user3.Send("user4", new MessageModel("吃了吗？", DateTime.Now)));
        Response.Write("<br />");
        Response.Write(user4.Send("user3", new MessageModel("没吃，你请我？", DateTime.Now)));
        Response.Write("<br />");
        Response.Write(user3.Send("user4", new MessageModel("不请。", DateTime.Now)));
        Response.Write("<br />");
    }
}
