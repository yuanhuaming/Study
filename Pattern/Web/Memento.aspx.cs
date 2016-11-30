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

using Pattern.Memento;

public partial class Memento : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        SqlMessage m = new SqlMessage();
        m.Message = "Message内容";
        m.PublishTime = DateTime.Now;

        MessageModelCaretaker mmc = new MessageModelCaretaker();
        mmc.MessageModel = m.SaveMemento();

        bool bln = false;
        while (!bln)
        {
            bln = m.Insert(new MessageModel(m.Message, m.PublishTime));

            Response.Write(m.Message + " " + m.PublishTime.ToString() + " " + bln.ToString());
            Response.Write("<br />");

            if (!bln)
            {
                System.Threading.Thread.Sleep(1000);

                m.RestoreMemento(mmc.MessageModel);
                m.PublishTime = DateTime.Now;
            }
        }
    }
}
