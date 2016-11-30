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

using Pattern.Singleton;

public partial class Singleton : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // 使用单例模式，保证一个类仅有一个实例
        Response.Write(Singleton<Test>.Instance.Time);
        Response.Write("<br />");
        Response.Write(Singleton<Test>.Instance.Time);
        Response.Write("<br />");

        // 不用单例模式
        Test t = new Test();
        Response.Write(t.Time);
        Response.Write("<br />");
        Test t2 = new Test();
        Response.Write(t2.Time);
        Response.Write("<br />");
    }
}

public class Test
{
    private DateTime _time;

    public Test()
    {
        System.Threading.Thread.Sleep(3000);
        _time = DateTime.Now;    
    }

    public string Time
    {
        get { return _time.ToString(); }
    }
}
