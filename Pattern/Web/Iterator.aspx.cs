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

using I = Pattern.Iterator;

public partial class Iterator : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        I::Collection collection = new I::Collection();

        collection[0] = new I::MessageModel("第1条信息", DateTime.Now);
        collection[1] = new I::MessageModel("第2条信息", DateTime.Now);
        collection[2] = new I::MessageModel("第3条信息", DateTime.Now);
        collection[3] = new I::MessageModel("第4条信息", DateTime.Now);
        collection[4] = new I::MessageModel("第5条信息", DateTime.Now);
        collection[5] = new I::MessageModel("第6条信息", DateTime.Now);
        collection[6] = new I::MessageModel("第7条信息", DateTime.Now);
        collection[7] = new I::MessageModel("第8条信息", DateTime.Now);
        collection[8] = new I::MessageModel("第9条信息", DateTime.Now);

        I::Iterator iterator = new I::Iterator(collection);

        iterator.Step = 2;

        for (I::MessageModel mm = iterator.First(); !iterator.IsDone; mm = iterator.Next())
        {
            Response.Write(mm.Message);
            Response.Write("<br />");
        }
    }
}
