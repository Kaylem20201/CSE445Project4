<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TryIt._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <div class="row">
            <section class="col-md-4" aria-labelledby="ValidateTitle">
                <h2 id="ValidateTitle">Validate XML</h2>
                <p>
                    <asp:Label ID="ValidateXmlUrlLabel" runat="server" Text="XML Url:"></asp:Label>
                    <asp:TextBox ID="ValidateXmlUrlInput" runat="server" TextMode="MultiLine"></asp:TextBox>
                    <asp:Label ID="ValidateXsdUrlLabel" runat="server" Text="XSD Url:"></asp:Label>
                    <asp:TextBox ID="ValidateXsdUrlInput" runat="server" TextMode="MultiLine"></asp:TextBox>
                    <asp:Button ID="ValidateButton" runat="server" Text="Validate" OnClick="Validate_Click" />
                    <asp:Label ID="ValidateResultLabel" runat="server" Text="Result:"></asp:Label>
                    <asp:TextBox ID="ValidateResultOutput" runat="server" BackColor="#999999" ReadOnly="True" TextMode="MultiLine"></asp:TextBox>
                </p>
            </section>
        </div>
        <div class="row">
            <section class="col-md-4" aria-labelledby="XPathTitle">
                <h2 id="XPathTitle">XPath Search</h2>
                <p>
                    <asp:Label ID="XPathXmlUrlLabel" runat="server" Text="XML Url:"></asp:Label>
                    <asp:TextBox ID="XPathXmlUrlInput" runat="server" TextMode="MultiLine"></asp:TextBox>
                    <asp:Label ID="XPathPathLabel" runat="server" Text="Path Expression:"></asp:Label>
                    <asp:TextBox ID="XPathPathInput" runat="server" TextMode="MultiLine"></asp:TextBox>
                    <asp:Button ID="XPathButton" runat="server" Text="Search" OnClick="XPath_Click" />
                    <asp:Label ID="XPathResultLabel" runat="server" Text="Result:"></asp:Label>
                    <asp:TextBox ID="XPathResultOutput" runat="server" BackColor="#999999" ReadOnly="True" TextMode="MultiLine"></asp:TextBox>
                </p>
            </section>
        </div>
    </main>

</asp:Content>
