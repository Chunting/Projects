<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ControlTree.aspx.cs" Inherits="ControlTree"  Trace="true"%>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <p><i>This is static HTML(not a web control).</i></p>
    <form id="form1" method="post" runat="server">
    <div>
        <asp:Panel ID="MainPanel" runat="server" Height="112px">
        <p>
            <asp:Button ID="Button1" runat="server" Text="Button1" />
            <asp:Button ID="Button2" runat="server" Text="Button2" />
            <asp:Button ID="Button3" runat="server" Text="Button3" />
        </p>
        <p>
            <asp:Label ID="Label1" runat="server">Name:</asp:Label>          
        </p>
        </asp:Panel>
        <p>
            <asp:Button ID="Button4" runat="server" Text="Button4" OnClick="On_Button4_Click" />
        </p>
    </div>
    </form>
    <p><i>This is static HTML(not a web control).</i></p>
</body>
</html>
