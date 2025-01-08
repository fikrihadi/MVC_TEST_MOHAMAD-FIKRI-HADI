<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DynamicallyGenerated.aspx.cs" Inherits="MVC_TEST_MOHAMAD_FIKRI_HADI.View.DynamicallyGenerated" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>Dynamic Control Generator</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            margin: 20px;
        }
        label {
            display: block;
            margin-top: 10px;
        }
        input, select, button {
            margin-top: 5px;
        }
        .generated-controls {
            margin-top: 20px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Dynamic Control Generator</h2>
            <label for="ddlControlType">Select Control Type:</label>
            <asp:DropDownList ID="ddlControlType" runat="server">
                <asp:ListItem Text="TextBox" Value="TextBox" />
                <asp:ListItem Text="CheckBox" Value="CheckBox" />
                <asp:ListItem Text="Button" Value="Button" />
            </asp:DropDownList>

            <label for="txtNumberOfControls">Number of Controls:</label>
            <asp:TextBox ID="txtNumberOfControls" runat="server" />

            <asp:Button ID="btnGenerate" runat="server" Text="Generate" OnClick="btnGenerate_Click" />
        </div>
        <div class="generated-controls">
            <asp:Panel ID="pnlGeneratedControls" runat="server"></asp:Panel>
        </div>
    </form>
</body>
</html>

