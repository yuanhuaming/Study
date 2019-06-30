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

using Pattern.Observer;

public partial class Observer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        MessageSubject m = new MessageSubject(new MessageModel("插入Message", DateTime.Now));

        SqlMessage sqlMessage = new SqlMessage();
        XmlMessage xmlMessage = new XmlMessage();

        m.Attach(sqlMessage);
        m.Attach(xmlMessage);

        var model = new MessageModel("插入Message", DateTime.Now);
        model.PropertyChanged += Model_PropertyChanged;
     
        System.Threading.Thread.Sleep(1000);

        Response.Write(m.Notify());
        //修改了PublishTime就会通知所有观察者
        m.PublishTime = DateTime.Now;
      
        Response.Write(m.Notify());
    }

    private void Model_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
    {
        //    e.PropertyName
    }
}
