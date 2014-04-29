<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default6.aspx.cs" Inherits="Default6" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:AdRotator AdvertisementFile="~/Ads.xml" Target="_blank" runat="server" />
        <asp:ListBox runat="server" ID="Listbox1" SelectionMode="Multiple" Rows="5">
            <asp:ListItem Selected="True">Option 1</asp:ListItem>
            <asp:ListItem>Option 2</asp:ListItem>
        </asp:ListBox>
        <br /><br />
        <asp:TextBox ID="Name" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ControlToValidate="Name" ErrorMessage="Name is required." Display="Dynamic" runat="server"><font color="red">*Required</font></asp:RequiredFieldValidator>
        <input type="submit" value="Submit" />

    </div>
    </form>
</body>
</html>
