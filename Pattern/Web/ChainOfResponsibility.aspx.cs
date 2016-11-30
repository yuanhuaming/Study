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

using Pattern.ChainOfResponsibility;

public partial class ChainOfResponsibility : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        AbstractExecutor employee = new Employee();
        AbstractExecutor leader = new Leader();
        AbstractExecutor manager = new Manager();
        employee.SetSuccessor(leader);
        leader.SetSuccessor(manager);

        Response.Write(employee.Insert(new MessageModel("abcd", DateTime.Now)));
        Response.Write("<br />");
        Response.Write(employee.Insert(new MessageModel("abcdefgh", DateTime.Now)));
        Response.Write("<br />");
        Response.Write(employee.Insert(new MessageModel("abcdefghigkl", DateTime.Now)));
        Response.Write("<br />");
        Response.Write(employee.Insert(new MessageModel("abcdefghigklmnop", DateTime.Now)));
    }
}
