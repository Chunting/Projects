using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;

public partial class UseCustomSettings : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        OrderService custSection = (OrderService)ConfigurationManager.GetSection("orderService");
        Label1.Text += "Retrieved service information...<br />"+"<b>Location:</>"+custSection.Location;
    }
}