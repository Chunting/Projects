<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default4.aspx.cs" Inherits="Default4" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <select runat="server" id="List1" size="5">
            <option>Option1</option>
            <option>Option2</option>
        </select>
        <br />
        <input type="text" runat="server" id="Textbox1" size="10" onserverchange="Ctrl_ServerChange" /><br />
        <input type="checkbox" runat="server" id="Checkbox1" onserverchange="Ctrl_ServerChange" />Option text<br />
        <input type="submit" runat="server" id="Submit1" value="Submit Query" />
        <asp:Panel ID="Panel1" runat="server" Height="116px" Width="278px" BorderStyle="Solid" BorderWidth="1px" ScrollBars="Auto">
            This scrolls.<br /><br />
            <asp:Button ID="Button1" runat="server" Text="Button" />
            <asp:Button ID="Button2" runat="server" Text="Button" />
            <br />
        </asp:Panel>
    </div>
    </form>
</body>
</html>
