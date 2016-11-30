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

using Pattern.Prototype;

public partial class Prototype : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Response.Write("ShallowCopy演示如下：<br />");
        ShowShallowCopy();

        Response.Write("DeepCopy演示如下：<br />");
        ShowDeepCopy();    
    }

    private void ShowShallowCopy()
    {
        ShallowCopy sc = new ShallowCopy();
        sc.MessageModel = new MessageModel("ShallowCopy", DateTime.Now);

        ShallowCopy sc2 = (ShallowCopy)sc.Clone();

        Response.Write(sc.MessageModel.Message);
        Response.Write("<br />");
        Response.Write(sc2.MessageModel.Message);
        Response.Write("<br />");

        sc.MessageModel.Message = "ShallowCopyShallowCopy";

        Response.Write(sc.MessageModel.Message);
        Response.Write("<br />");
        Response.Write(sc2.MessageModel.Message);
        Response.Write("<br />");
    }

    private void ShowDeepCopy()
    {
        DeepCopy sc = new DeepCopy();
        sc.MessageModel = new MessageModel("DeepCopy", DateTime.Now);

        DeepCopy sc2 = (DeepCopy)sc.Clone();

        Response.Write(sc.MessageModel.Message);
        Response.Write("<br />");
        Response.Write(sc2.MessageModel.Message);
        Response.Write("<br />");

        sc.MessageModel.Message = "DeepCopyDeepCopy";

        Response.Write(sc.MessageModel.Message);
        Response.Write("<br />");
        Response.Write(sc2.MessageModel.Message);
        Response.Write("<br />");
    }
}
