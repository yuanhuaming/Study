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

using Pattern.Flyweight;

public partial class Flyweight : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string[] ary = new string[] { "xml", "sql" };

        MessageFactory messageFactory = new MessageFactory();

        foreach (string key in ary)
        {
            AbstractMessage messageObject = messageFactory.GetMessageObject(key);

            Response.Write(messageObject.Insert(new MessageModel("插入", DateTime.Now)));
            Response.Write("<br />");
            Response.Write(messageObject.Get()[0].Message + " " + messageObject.Get()[0].PublishTime.ToString());
            Response.Write("<br />");
        }
    }
}
