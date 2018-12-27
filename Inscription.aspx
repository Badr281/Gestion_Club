<%@ Page Title="" Language="C#" MasterPageFile="~/Club.Master" AutoEventWireup="true" CodeBehind="Inscription.aspx.cs" Inherits="Gestion_club.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="zone1" runat="server">
    <table class="auto-style6">
        <tr>
            <td class="auto-style8" style="font-family: Arial; color: #000099">Nom :</td>
            <td>
                <asp:TextBox ID="nom" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="nom" ErrorMessage="Le nom et obligatoire" ForeColor="#996600"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style8" style="font-family: Arial; color: #000099">Prenom :</td>
            <td>
                <asp:TextBox ID="prenom" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="prenom" ErrorMessage="*" ForeColor="#996600"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style8" style="font-family: Arial; color: #000099">Adresse :</td>
            <td>
                <asp:TextBox ID="adresse" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="adresse" ErrorMessage="*" ForeColor="#996600"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style8" style="font-family: Arial; color: #000099">Telephone :</td>
            <td>
                <asp:TextBox ID="telephone" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="telephone" ErrorMessage="*" ForeColor="#996600"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="telephone" ErrorMessage="Numéro nom-valide" ValidationExpression="(0(6|7|5)?)\d\d\d\d\d\d\d\d"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style8" style="font-family: Arial; color: #000099">Date début :</td>
            <td>
                <asp:TextBox ID="dated" runat="server"></asp:TextBox>
                <asp:Button ID="cal" runat="server" Text="Cal" />
                <br />
                <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
            </td>
        </tr>
        <tr>
            <td class="auto-style9" style="font-family: Arial; color: #000099">Type sport :<br />
                Nom a modfier</td>
            <td class="auto-style10">
                <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="libele" DataValueField="id">
                </asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Gestion_clubConnectionString %>" SelectCommand="SELECT * FROM [sport]"></asp:SqlDataSource>
                <asp:DropDownList ID="DropDownList2" runat="server" DataSourceID="SqlDataSource2" DataTextField="nom" DataValueField="id" Width="169px">
                </asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:Gestion_clubConnectionString %>" SelectCommand="SELECT * FROM [adherent]"></asp:SqlDataSource>
                <br />
                <asp:Button ID="Button1" runat="server" Text="Button" />
                <br />
                <table class="auto-style6">
                    <tr>
                        <td class="auto-style11">&nbsp;Choisir une date :&nbsp;<asp:TextBox ID="TextBox1" runat="server" AutoPostBack="True" OnTextChanged="TextBox1_TextChanged" ViewStateMode="Disabled"></asp:TextBox>
                            <asp:Calendar ID="Calendar2" runat="server" OnSelectionChanged="Calendar2_SelectionChanged"></asp:Calendar>
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                </table>
                <br />
            </td>
        </tr>
        <tr>
            <td class="auto-style8" style="font-family: Arial; color: #000099">
                <asp:Button ID="Ajouter" runat="server" Text="Ajouter" Width="301px" OnClick="Ajouter_Click" />
            </td>
            <td>
                <asp:Button ID="modifier" runat="server" OnClick="modifier_Click" Text="Modifier" Width="261px" />
                <asp:Button ID="supprimer" runat="server" Text="Supprimer" Width="261px" OnClick="supprimer_Click" />
                <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Button" Width="218px" />
            </td>
        </tr>
    </table>
</asp:Content>
<asp:Content ID="Content2" runat="server" contentplaceholderid="head">
    <style type="text/css">
        .auto-style6 {
            width: 100%;
        }
        .auto-style8 {
            width: 238px;
            text-align: center;
        }
        .auto-style9 {
            width: 238px;
            text-align: center;
            height: 175px;
        }
        .auto-style10 {
            height: 175px;
        }
        .auto-style11 {
            width: 1050px;
        }
        </style>
</asp:Content>

