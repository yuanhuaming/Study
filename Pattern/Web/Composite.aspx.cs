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

using Pattern.Composite;

public partial class Composite : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        MessageModelComposite root = new MessageModelComposite("树枝A");

        root.Add(new MessageModelLeaf("树叶A", new MessageModel("Message内容A", DateTime.Now)));
        root.Add(new MessageModelLeaf("树叶B", new MessageModel("Message内容B", DateTime.Now)));

        MessageModelComposite comp = new MessageModelComposite("树枝B");

        comp.Add(new MessageModelLeaf("树叶C", new MessageModel("Message内容C", DateTime.Now)));
        comp.Add(new MessageModelLeaf("树叶D", new MessageModel("Message内容D", DateTime.Now)));

        root.Add(comp);

        root.Add(new MessageModelLeaf("树叶E", new MessageModel("Message内容E", DateTime.Now)));

        MessageModelLeaf l = new MessageModelLeaf("树叶F", new MessageModel("Message内容F", DateTime.Now));
        
        root.Add(l);
        root.Remove(l);

        Response.Write(root.GetData(1));
    }
}
