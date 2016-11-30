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

using Pattern.Provider;

public partial class Provider : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Response.Write(Message.Insert(new MessageModel("插入", DateTime.Now)));
        Response.Write("<br />");
        Response.Write(Message.Get()[0].Message + " " + Message.Get()[0].PublishTime.ToString());
    }
}

/*配置文件中的配置
 * 
<configuration>
    <configSections>
        <section name="MessageProvider" type="Pattern.Provider.MessageProviderConfigurationSection, Pattern.Provider" />
    </configSections>
    <MessageProvider defaultProvider="SqlMessageProvider">
        <providers>
            <add name="XmlMessageProvider" type="Pattern.Provider.XmlMessageProvider, Pattern.Provider" connectionStringName="XmlConnection" />
            <add name="SqlMessageProvider" type="Pattern.Provider.SqlMessageProvider, Pattern.Provider" connectionStringName="SqlConnection" />
        </providers>
    </MessageProvider>
    <connectionStrings>
        <add name="SqlConnection" connectionString="server=.;database=db;uid=sa;pwd=sa" />
        <add name="XmlConnection" connectionString="XmlPath" />
    </connectionStrings>
</configuration>
 * 
*/
