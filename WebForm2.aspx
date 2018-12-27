<%@ Page Title="" Language="C#" MasterPageFile="~/Club.Master" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="Gestion_club.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style6 {
            width: 100%;
        }
        .auto-style7 {
            text-align: center;
            width: 405px;
        }
        .auto-style8 {
            text-align: center;
            width: 405px;
            height: 31px;
        }
        .auto-style9 {
            height: 31px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="zone1" runat="server">
    <table class="auto-style6">
        <tr>
            <td class="auto-style7">NOM :</td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style7">Prenom :</td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style7">Date payement : </td>
            <td>
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style8">Payement :</td>
            <td class="auto-style9">
                <asp:RadioButton ID="RadioButton1" runat="server" OnCheckedChanged="RadioButton1_CheckedChanged" Text="payer" />
            </td>
        </tr>
        <tr>
            <td class="auto-style8">&nbsp;</td>
            <td class="auto-style9">
                <asp:Button ID="Valider" runat="server" OnClick="Button1_Click" Text="Valider" />
            </td>
        </tr>
    </table>
</asp:Content>
