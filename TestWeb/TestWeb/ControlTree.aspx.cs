using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ControlTree : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Trace.TraceMode = TraceMode.SortByCategory;
        foreach (Control control in Page.Controls)
        {
            //Response.Write("***Text: "+Server.HtmlEncode(((LiteralControl)control).Text.ToString())+"<br />");
        }
    }

    protected void On_Button4_Click(object sender, EventArgs e)
    {
        Button foundButton = (Button)Page.FindControl("Button1");
        if (foundButton != null)
        {
            foundButton.Parent.Controls.Remove(foundButton);
        }

        Trace.Warn("Button4_Click","About to update the label.");
        Label1.Text += "Button4.Click event handled.<br />";
        Trace.Warn("Button4_Click","Label updated.");
    }
}