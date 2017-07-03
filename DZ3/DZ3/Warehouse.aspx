<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Warehouse.aspx.cs" Inherits="DZ3.Warehouse" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body> 
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="Категория"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBoxCategory" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text="Название"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBoxName" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label3" runat="server" Text="Цена"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBoxPrice" runat="server"></asp:TextBox>
                    </td>
                </tr>
            </table>    
        </div><br />
        <asp:Button ID="Button1" runat="server" Text="Добавить продукт" OnClick="Button1_Click" />
    </form>
</body>
</html>
