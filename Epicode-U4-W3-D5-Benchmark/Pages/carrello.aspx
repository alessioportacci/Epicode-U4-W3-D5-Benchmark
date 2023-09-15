<%@ Page Title="" Language="C#" EnableEventValidation="false" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="carrello.aspx.cs" Inherits="Epicode_U4_W3_D5_Benchmark.Pages.carrello" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row row-cols-1">
        
        <h1>Carrello:</h1>

        <asp:Repeater ID="RepeaterCarrello" runat="server" ItemType="Epicode_U4_W3_D5_Benchmark.Articolo">
            <ItemTemplate>

                <div>

                    <div class="row row row-cols-4 m-3">
                        <div><img src="../Content/imgs/<%# Item.Foto %>" height="50" /></div>
                        <div><p> <%# Item.Nome %> - <%#Item.Prezzo %> €</p></div>
                        <div><asp:Button ID="BUTTON" CssClass="btn btn-secondary" runat="server" Text="Rimuovi" CommandArgument="<%#Item.ID %>" OnClick="Rimuovi_Click" /></div>

                    </div>
                   
                </div>

            </ItemTemplate>
        </asp:Repeater>

    </div>

    <hr />

    <div class="row row-cols-2 ">

        <div>  <h3 ID="Totale" runat="server" class="my-2"></h3> </div>
        <div> <asp:Button ID="SvuotaCarrello" CssClass="my-2 btn btn-secondary" runat="server" Text="Svuota Carrello" OnClick="SvuotaCarrello_Click"/> </div>
        
    </div>
   
</asp:Content>
