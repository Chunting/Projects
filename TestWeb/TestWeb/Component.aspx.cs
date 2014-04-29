using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Component : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        SherlockQuotes quotes = new SherlockQuotes(Server.MapPath("./sherlock-holmes.xml"));
        Quotation quote = quotes.GetRandomQuote();
        Response.Write("<b>"+quote.Source+"</b> (<i>"+quote.Date+"</i>)");
        Response.Write("<blockquote>"+quote.QuotationText+"</blockquote>");
    }
}