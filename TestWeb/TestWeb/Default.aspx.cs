using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Label1.Text += "<b>This is not the first time you've seen this page.</b><br />";
        }

        foreach (Control control in Page.Controls)
        {
            Response.Write(control.GetType().ToString()+"-<b>"+control.ID+"</b><br />");
        }
        Response.Write("<hr />");
        HttpContext.Current.Trace.Write("This message is from DB Component.");

    }

    protected void Page_Init(object sender, EventArgs e)
    {
        Label1.Text += "Page.Init event handled.<br />";
    }

    protected void Page_PreRender(object sender, EventArgs e)
    {
        Label1.Text += "Page.PreRener event handled.<br />";
    }

    protected void Page_Unload(object sender, EventArgs e)
    {
        Label1.Text += "Page.Unload event handled.<br />";
    }
}