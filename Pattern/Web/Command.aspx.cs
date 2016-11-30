using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

using Pattern.Command;

public partial class Command : System.Web.UI.Page
{
    protected void Page_Load(object sender, System.EventArgs e)
    {
        Message m = new Message();

        Response.Write("操作");
        Response.Write("<br />");
        Response.Write(m.Do(Action.Insert, new MessageModel("第1条", System.DateTime.Now)));
        Response.Write("<br />");
        Response.Write(m.Do(Action.Insert, new MessageModel("第2条", System.DateTime.Now)));
        Response.Write("<br />");
        Response.Write(m.Do(Action.Insert, new MessageModel("第3条", System.DateTime.Now)));
        Response.Write("<br />");
        Response.Write(m.Do(Action.Insert, new MessageModel("第4条", System.DateTime.Now)));
        Response.Write("<br />");
        Response.Write(m.Do(Action.Delete, new MessageModel("第2条", System.DateTime.Now)));
        Response.Write("<br />");
        Response.Write(m.Do(Action.Insert, new MessageModel("第5条", System.DateTime.Now)));
        Response.Write("<br />");
        Response.Write(m.Do(Action.Delete, new MessageModel("第3条", System.DateTime.Now)));
        Response.Write("<br />");
        Response.Write(m.Do(Action.Insert, new MessageModel("第6条", System.DateTime.Now)));
        Response.Write("<br />");
        Response.Write(m.Do(Action.Insert, new MessageModel("第7条", System.DateTime.Now)));
        Response.Write("<br />");
        Response.Write("<br />");

        Response.Write("撤销4次操作");
        Response.Write("<br />");
        Response.Write(m.Undo(4));
        Response.Write("<br />");
        Response.Write("<br />");

        Response.Write("重复2次操作");
        Response.Write("<br />");
        Response.Write(m.Redo(2));
        Response.Write("<br />");
        Response.Write("<br />");

        Response.Write("撤销3次操作");
        Response.Write("<br />");
        Response.Write(m.Undo(3));
    }
}
