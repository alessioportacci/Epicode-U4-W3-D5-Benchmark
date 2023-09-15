<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="dettaglioArticolo.aspx.cs" Inherits="Epicode_U4_W3_D5_Benchmark.Pages.dettaglioArticolo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    

    <h1 ID="Nome" runat="server" ></h1>
    <p id="Rimaste" runat="server" class="text-secondary"></p>


    <div class="row-cols-1 justify-content-center my-5" height="100">
        <div class="text-center">
            <img ID="Immagine" runat="server" src=""/>
        </div>
        <div>
        </div>
    </div>

    <p ID="Descrizione" runat="server" ></p>

    <asp:Button ID="Aggiungi" CssClass="btn btn-danger" runat="server" Text="Aggiungi al Carrello" OnClick="Aggiungi_Click" />
    <p ID="Aggiunto" runat="server"></p>

</asp:Content>
