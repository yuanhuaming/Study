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

using Microsoft.CSharp;
using System.Reflection;
using System.Text;
using System.Collections.Generic;

using Pattern.Interpreter;

public partial class Interpreter : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string chinese = "{数据库}[信息](获取)";
        Context context = new Context(chinese);

        List<AbstractExpression> l = new List<AbstractExpression>();
        l.Add(new DatabaseExpression());
        l.Add(new ObjectExpression());
        l.Add(new MethodExpression());

        foreach (AbstractExpression exp in l)
        {
            exp.Interpret(context);
        }

        Assembly assembly = Assembly.Load("Pattern.Interpreter");
        MethodInfo method = assembly.GetType("Pattern.Interpreter." + context.Output.Split('.')[0]).GetMethod(context.Output.Split('.')[1].Replace("()", ""));
        object obj = method.Invoke(null, null);

        List<MessageModel> m = (List<MessageModel>)obj;

        Response.Write("中文语法：" + chinese);
        Response.Write("<br />");
        Response.Write("解释后的C#代码：" + context.Output);
        Response.Write("<br />");
        Response.Write("执行结果：" + m[0].Message + " " + m[0].PublishTime.ToString());
    }
}
